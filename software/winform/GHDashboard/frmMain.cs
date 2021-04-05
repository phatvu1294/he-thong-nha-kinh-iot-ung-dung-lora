using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace GHDashboard
{
    public partial class frmMain : Form
    {
        const string MQTT_SERVER = "m21.cloudmqtt.com";
        const string MQTT_USERNAME = "igidqkav";
        const string MQTT_PASSWORD = "HL21gpbm4N-p";

        const string TOPIC_ONOFF1 = "phatvu1294/ghsystem/onoff1";
        const string TOPIC_ONOFF2 = "phatvu1294/ghsystem/onoff2";
        const string TOPIC_ONOFF3 = "phatvu1294/ghsystem/onoff3";
        const string TOPIC_ONOFF4 = "phatvu1294/ghsystem/onoff4";
        const string TOPIC_CO2 = "phatvu1294/ghsystem/co2";
        const string TOPIC_TEMP = "phatvu1294/ghsystem/temp";
        const string TOPIC_LIGHT = "phatvu1294/ghsystem/light";

        const int ON_STATE = 1;
        const int OFF_STATE = 0;

        const string ON_LABEL = "Bật";
        const string OFF_LABEL = "Tắt";

        const string CO2_LABEL = "Nồng độ CO2: ";
        const string TEMP_LABEL = "Nhiệt độ: ";
        const string LIGHT_LABEL = "Độ xuyên sáng: ";
        const string INC_LABEL = "▲ ";
        const string DEC_LABEL = "▼ ";

        const string DEVICE1_LABEL = "Thiết bị 1";
        const string DEVICE2_LABEL = "Thiết bị 2";
        const string DEVICE3_LABEL = "Thiết bị 3";
        const string DEVICE4_LABEL = "Thiết bị 4";

        const string ISON_LABEL = " đã được bật";
        const string ISOFF_LABEL = " đã được tắt";

        const string LBRACKETS_LABEL = " (";
        const string RBRACKETS_LABEL = ")";

        const string PPM_LABEL = "ppm";
        const string DEGREE_LABEL = "°C";
        const string LUX_LABEL = "lx";
        const string PERCENT_LABEL = "%";

        string iniPath = new FileInfo(Assembly.GetExecutingAssembly().GetName().Name + ".ini").FullName.ToString();
        string datPath = AppDomain.CurrentDomain.BaseDirectory + "\\data\\";
        string binPath = AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + DateTime.Now.ToString("yyyyMMdd") + ".bin";

        string co2Str = "", tempStr = "", lightStr = "", controlStr = "", tempBuf = "", lightBuf = "";
        int[] tempArr, lightArr;
        int co2 = 0, temp = 0, light = 0, co2Old = 0, tempOld = 0, lightOld = 0, i = 0;
        int onoff1 = OFF_STATE, onoff2 = OFF_STATE, onoff3 = OFF_STATE, onoff4 = OFF_STATE;

        MqttClient client;

        frmLog log;

        public frmMain()
        {
            InitializeComponent();
            log = new frmLog();

            try
            {
                client = new MqttClient(MQTT_SERVER);
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                client.MqttMsgPublished += client_MqttMsgPublished;
                client.Connect(Guid.NewGuid().ToString(), MQTT_USERNAME, MQTT_PASSWORD, true, 1000);
            }
            catch
            {
                Application.Exit();
                MessageBox.Show("Lỗi! Không thể kết nối tới MQTT\nVui lòng kiểm tra lại kết nối mạng", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            onoff1 = int.TryParse(IniFile.ReadValue("Control", "onoff1", iniPath, "0"), out i) ? i : 0;
            onoff2 = int.TryParse(IniFile.ReadValue("Control", "onoff2", iniPath, "0"), out i) ? i : 0;
            onoff3 = int.TryParse(IniFile.ReadValue("Control", "onoff3", iniPath, "0"), out i) ? i : 0;
            onoff4 = int.TryParse(IniFile.ReadValue("Control", "onoff4", iniPath, "0"), out i) ? i : 0;
            co2 = int.TryParse(IniFile.ReadValue("Monitoring", "co2", iniPath, "0"), out i) ? i : 0;
            tempBuf = IniFile.ReadValue("Monitoring", "temp", iniPath, "0");
            lightBuf = IniFile.ReadValue("Monitoring", "light", iniPath, "0");

            tempArr = Array.ConvertAll(tempBuf.Split(','), s => int.TryParse(s, out i) ? i : 0);
            lightArr = Array.ConvertAll(lightBuf.Split(','), s => int.TryParse(s, out i) ? i : 0);

            temp = (int)Math.Round(tempArr.Average(), 0, MidpointRounding.AwayFromZero);
            light = (lightArr[0] != 0 && lightArr.Length >= 2) ? (int)Math.Round((double)lightArr[1] * 100 / lightArr[0], 0, MidpointRounding.AwayFromZero) : 0;

            this.Invoke((MethodInvoker)delegate { SetMonitoringComponent(); });

            client.Subscribe(new string[] { TOPIC_CO2, TOPIC_TEMP, TOPIC_LIGHT },
                new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });

            if (File.Exists(binPath))
            {
                log.dgvLog.Rows.Clear();

                using (BinaryReader bw = new BinaryReader(File.Open(binPath, FileMode.Open)))
                {
                    int n = bw.ReadInt32();
                    int m = bw.ReadInt32();
                    for (i = 0; i < m; ++i)
                    {
                        log.dgvLog.Rows.Add();

                        for (int j = 0; j < n; ++j)
                        {
                            if (bw.ReadBoolean())
                            {
                                log.dgvLog.Rows[i].Cells[j].Value = bw.ReadString();
                            }
                            else bw.ReadBoolean();
                        }
                    }
                }
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Directory.Exists(datPath)) Directory.CreateDirectory(datPath);

            using (BinaryWriter bw = new BinaryWriter(File.Open(binPath, FileMode.Create)))
            {
                bw.Write(log.dgvLog.Columns.Count);
                bw.Write(log.dgvLog.Rows.Count);

                foreach (DataGridViewRow dgvR in log.dgvLog.Rows)
                {
                    for (int j = 0; j < log.dgvLog.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;

                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
            }

            IniFile.WriteValue("Control", "onoff1", onoff1.ToString(), iniPath);
            IniFile.WriteValue("Control", "onoff2", onoff2.ToString(), iniPath);
            IniFile.WriteValue("Control", "onoff3", onoff3.ToString(), iniPath);
            IniFile.WriteValue("Control", "onoff4", onoff4.ToString(), iniPath);
            IniFile.WriteValue("Monitoring", "co2", co2.ToString(), iniPath);
            IniFile.WriteValue("Monitoring", "temp", tempBuf, iniPath);
            IniFile.WriteValue("Monitoring", "light", lightBuf, iniPath);

            client.Unsubscribe(new string[] { TOPIC_CO2, TOPIC_TEMP, TOPIC_LIGHT });
            client.Disconnect();
        }

        private void mnuLog_Click(object sender, EventArgs e)
        {
            log.ShowDialog();
        }

        private void mniAbout_Click(object sender, EventArgs e)
        {
            frmAbout About = new frmAbout();
            About.ShowDialog();
        }

        private void chkOnoff1_Click(object sender, EventArgs e)
        {
            controlStr = DEVICE1_LABEL;

            if (onoff1 == ON_STATE)
            {
                onoff1 = OFF_STATE;
                controlStr += ISOFF_LABEL;
                chkOnoff1.Checked = false;
                chkOnoff1.Text = ON_LABEL;
            }
            else if (onoff1 == OFF_STATE)
            {
                onoff1 = ON_STATE;
                controlStr += ISON_LABEL;
                chkOnoff1.Checked = true;
                chkOnoff1.Text = OFF_LABEL;
            }

            client.Publish(TOPIC_ONOFF1, Encoding.UTF8.GetBytes(onoff1.ToString()), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, true);
        }

        private void chkOnoff2_Click(object sender, EventArgs e)
        {
            controlStr = DEVICE2_LABEL;

            if (onoff2 == ON_STATE)
            {
                onoff2 = OFF_STATE;
                controlStr += ISOFF_LABEL;
                chkOnoff2.Checked = false;
                chkOnoff2.Text = ON_LABEL;
            }
            else if (onoff2 == OFF_STATE)
            {
                onoff2 = ON_STATE;
                controlStr += ISON_LABEL;
                chkOnoff2.Checked = true;
                chkOnoff2.Text = OFF_LABEL;
            }

            client.Publish(TOPIC_ONOFF2, Encoding.UTF8.GetBytes(onoff2.ToString()), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, true);
        }

        private void chkOnoff3_Click(object sender, EventArgs e)
        {
            controlStr = DEVICE1_LABEL;

            if (onoff3 == ON_STATE)
            {
                onoff3 = OFF_STATE;
                controlStr += ISOFF_LABEL;
                chkOnoff3.Checked = false;
                chkOnoff3.Text = ON_LABEL;
            }
            else if (onoff3 == OFF_STATE)
            {
                onoff3 = ON_STATE;
                controlStr += ISON_LABEL;
                chkOnoff3.Checked = true;
                chkOnoff3.Text = OFF_LABEL;
            }

            client.Publish(TOPIC_ONOFF3, Encoding.UTF8.GetBytes(onoff3.ToString()), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, true);

        }

        private void chkOnoff4_Click(object sender, EventArgs e)
        {
            controlStr = DEVICE1_LABEL;

            if (onoff4 == ON_STATE)
            {
                onoff4 = OFF_STATE;
                controlStr += ISOFF_LABEL;
                chkOnoff4.Checked = false;
                chkOnoff4.Text = ON_LABEL;
            }
            else if (onoff4 == OFF_STATE)
            {
                onoff4 = ON_STATE;
                controlStr += ISON_LABEL;
                chkOnoff4.Checked = true;
                chkOnoff4.Text = OFF_LABEL;
            }

            client.Publish(TOPIC_ONOFF4, Encoding.UTF8.GetBytes(onoff4.ToString()), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, true);

        }

        private void SetControlValue()
        {
            if (onoff1 == ON_STATE)
            {
                chkOnoff1.Checked = true;
                chkOnoff1.Text = OFF_LABEL;
            }
            else if (onoff1 == OFF_STATE)
            {
                chkOnoff1.Checked = false;
                chkOnoff1.Text = ON_LABEL;
            }

            if (onoff2 == ON_STATE)
            {
                chkOnoff2.Checked = true;
                chkOnoff2.Text = OFF_LABEL;
            }
            else if (onoff2 == OFF_STATE)
            {
                chkOnoff2.Checked = false;
                chkOnoff2.Text = ON_LABEL;
            }

            if (onoff3 == ON_STATE)
            {
                chkOnoff3.Checked = true;
                chkOnoff3.Text = OFF_LABEL;
            }
            else if (onoff3 == OFF_STATE)
            {
                chkOnoff3.Checked = false;
                chkOnoff3.Text = ON_LABEL;
            }

            if (onoff4 == ON_STATE)
            {
                chkOnoff4.Checked = true;
                chkOnoff4.Text = OFF_LABEL;
            }
            else if (onoff4 == OFF_STATE)
            {
                chkOnoff4.Checked = false;
                chkOnoff4.Text = ON_LABEL;
            }

        }

        private void SetControlComponent()
        {
            log.dgvLog.Rows.Insert(0, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss"), controlStr);
        }

        private void SetMonitoringComponent()
        {
            gaeCO2.Value = co2;
            lblCO2.Text = co2.ToString() + PPM_LABEL;
            gaeTemp.Value = temp;
            lblTemp.Text = temp.ToString() + DEGREE_LABEL;
            gaeLight.Value = light;
            lblLight.Text = light.ToString() + PERCENT_LABEL;

            lblLightBefore.Text = lightArr[0].ToString() + LUX_LABEL;
            lblLightAfter.Text = ((lightArr.Length >= 2) ? lightArr[1].ToString() : "0") + LUX_LABEL;

            chtTemp.Series[0].Points.Clear();

            for (int i = 0; i < tempArr.Length; i++)
            {
                chtTemp.Series[0].Points.AddXY(i + 1, tempArr[i]);
                chtTemp.Series[0].Points[i].AxisLabel = "Điểm " + (i + 1).ToString();
            }

            co2Str = CO2_LABEL + co2 + PPM_LABEL;
            tempStr = TEMP_LABEL + temp + DEGREE_LABEL;
            lightStr = LIGHT_LABEL + light + PERCENT_LABEL;

            if (co2 > co2Old)
                co2Str += LBRACKETS_LABEL + INC_LABEL + (co2 - co2Old).ToString() + PPM_LABEL + RBRACKETS_LABEL;
            else if (co2 < co2Old)
                co2Str += LBRACKETS_LABEL + DEC_LABEL + (co2Old - co2).ToString() + PPM_LABEL + RBRACKETS_LABEL;

            if (temp > tempOld)
                tempStr += LBRACKETS_LABEL + INC_LABEL + (temp - tempOld).ToString() + DEGREE_LABEL + RBRACKETS_LABEL;
            else if (temp < tempOld)
                tempStr += LBRACKETS_LABEL + DEC_LABEL + (tempOld - temp).ToString() + DEGREE_LABEL + RBRACKETS_LABEL;

            if (light > lightOld)
                lightStr += LBRACKETS_LABEL + INC_LABEL + (light - lightOld).ToString() + PERCENT_LABEL + RBRACKETS_LABEL;
            else if (light < lightOld)
                lightStr += LBRACKETS_LABEL + DEC_LABEL + (lightOld - light).ToString() + PERCENT_LABEL + RBRACKETS_LABEL;

            log.dgvLog.Rows.Insert(0, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss"), co2Str + ", " + tempStr + ", " + lightStr);
        }

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            co2Old = co2;
            tempOld = temp;
            lightOld = light;

            if (e.Topic == TOPIC_CO2)
            {
                co2 = int.TryParse(Encoding.UTF8.GetString(e.Message), out i) ? i : 0;
            }
            else if (e.Topic == TOPIC_TEMP)
            {
                tempBuf = Encoding.UTF8.GetString(e.Message);
                tempArr = Array.ConvertAll(tempBuf.Split(','), s => int.TryParse(s, out i) ? i : 0);
                temp = (int)Math.Round(tempArr.Average(), 0, MidpointRounding.AwayFromZero);
            }
            else if (e.Topic == TOPIC_LIGHT)
            {
                lightBuf = Encoding.UTF8.GetString(e.Message);
                lightArr = Array.ConvertAll(lightBuf.Split(','), s => int.TryParse(s, out i) ? i : 0);
                light = (lightArr[0] != 0 && lightArr.Length >= 2) ? (int)Math.Round((double)lightArr[1] * 100 / lightArr[0], 0, MidpointRounding.AwayFromZero) : 0;
            }

            this.Invoke((MethodInvoker)delegate { SetMonitoringComponent(); });
        }

        void client_MqttMsgPublished(object sender, MqttMsgPublishedEventArgs e)
        {
            if (e.IsPublished == true)
                this.Invoke((MethodInvoker)delegate { SetControlComponent(); });
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GHDashboard
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            dgvLog.Columns["colDate"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLog.Columns["colTime"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLog.Columns["colLogEvent"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dgvLog_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentBackground);
                e.Handled = true;
            }
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

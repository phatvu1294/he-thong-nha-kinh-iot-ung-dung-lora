monitorings = [{
  topic: "phatvu1294/ghsystem/co2",
  gauge: new JustGage({
    id: "jgCO2",
    value: 0,
    min: 0,
    max: 5000,
    label: "ppm"
  }),
  levelClass: "co2-level",
  suggestClass: "co2-suggest",
  contents: [{
    value: [0, 1000],
    level: "Rất thấp",
    suggest: "Cây quang hợp rất kém!"
  }, {
    value: [1000, 2000],
    level: "Thấp",
    suggest: "Cây quang hợp kém!"
  }, {
    value: [2000, 3000],
    level: "Trung bình",
    suggest: "Cây quang hợp bình thường!"
  }, {
    value: [3000, 4000],
    level: "Cao",
    suggest: "Cây quang hợp tốt!"
  }, {
    value: [4000, 5000],
    level: "Rất cao",
    suggest: "Cây quang hợp rất tốt!"
  }]
}, {
  topic: "phatvu1294/ghsystem/temp",
  gauge: new JustGage({
    id: "jgTemp",
    value: 0,
    min: 0,
    max: 50,
    label: "°C"
  }),
  chartLabel: "Điểm ",
  chart: new Chart($("#chtTemp"), {
    type: "line",
    data: {
      labels: [],
      datasets: [{
        data: [],
        lineTension: 0,
        backgroundColor: "transparent",
        borderColor: "#0000ff",
        borderWidth: 3,
        pointBackgroundColor: "#e0e0e0"
      }]
    },
    options: {
      scales: {
        yAxes: [{
          ticks: {
            beginAtZero: true
          }
        }]
      },
      legend: {
        display: false,
      }
    }
  }),
  levelClass: "temp-level",
  suggestClass: "temp-suggest",
  contents: [{
    value: [0, 10],
    level: "Rất thấp",
    suggest: "Khỏi cần bổ sung nước!"
  }, {
    value: [10, 20],
    level: "Thấp",
    suggest: "Cần bổ sung nước!"
  }, {
    value: [20, 30],
    level: "Trung bình",
    suggest: "Cần bổ sung nhiều nước!"
  }, {
    value: [30, 40],
    level: "Cao",
    suggest: "Cần bổ sung rất nhiều nước!"
  }, {
    value: [40, 50],
    level: "Rất cao",
    suggest: "Cần bổ sung rất rất nhiều nước!"
  }]
}, {
  topic: "phatvu1294/ghsystem/light",
  gauge: new JustGage({
    id: "jgLight",
    value: 0,
    min: 0,
    max: 100,
    label: "%"
  }),
  lightBeforeClass: "light-before",
  lightAfterClass: "light-after",
  levelClass: "light-level",
  suggestClass: "light-suggest",
  contents: [{
    value: [0, 50],
    level: "Thấp",
    suggest: "Độ xuyên sáng thấp! Cần cải thiện!"
  }, {
    value: [50, 100],
    level: "Cao",
    suggest: "Độ xuyên sáng cao! Cần cải thiện!"
  }]
}];

var socket = io();

socket.on("server-monitoring-firstload", function(data) {
  for (var subscribe of data) {
    if (subscribe.topic == monitorings[0].topic) {
      var co2 = tryParseInt(subscribe.message, 0);
      monitorings[0].gauge.refresh(co2);

      for (var content of monitorings[0].contents) {
        if ((co2 < content.value[1]) &&
          (co2 >= content.value[0])) {
          $("." + monitorings[0].levelClass).text(content.level);
          $("." + monitorings[0].suggestClass).text(content.suggest);
        }
      }

    } else if (subscribe.topic == monitorings[1].topic) {
      var messages = subscribe.message.split(",");
      var labels = [];
      var total = 0;
      var amount = messages.length;

      for (var i = 0; i < amount; i++) {
        total += tryParseInt(messages[i], 0);
        labels[i] = monitorings[1].chartLabel + (i + 1);
      }

      var temp = (amount) ? Math.round(total / amount) : 0;

      monitorings[1].gauge.refresh(temp);
      monitorings[1].chart.data.labels = labels;
      monitorings[1].chart.data.datasets[0].data = messages.map(Number);
      monitorings[1].chart.update();

      for (var content of monitorings[1].contents) {
        if ((temp < content.value[1]) &&
          (temp >= content.value[0])) {
          $("." + monitorings[1].levelClass).text(content.level);
          $("." + monitorings[1].suggestClass).text(content.suggest);
        }
      }

    } else if (subscribe.topic == monitorings[2].topic) {
      var messages = subscribe.message.split(",");
      var den = tryParseInt(messages[0], 0);
      var num = tryParseInt(messages[1], 0);
      var light = (den) ? Math.round(num * 100 / den) : 0;

      $("." + monitorings[2].lightBeforeClass).text(den);
      $("." + monitorings[2].lightAfterClass).text(num);
      monitorings[2].gauge.refresh(light);

      for (var content of monitorings[2].contents) {
        if ((light < content.value[1]) &&
          (light >= content.value[0])) {
          $("." + monitorings[2].levelClass).text(content.level);
          $("." + monitorings[2].suggestClass).text(content.suggest);
        }
      }
    }
  }
});

socket.on("server-monitoring-response", function(data) {
  if (data.topic == monitorings[0].topic) {
    var co2 = tryParseInt(data.message, 0)
    monitorings[0].gauge.refresh(co2);

    for (var content of monitorings[0].contents) {
      if ((co2 < content.value[1]) &&
        (co2 >= content.value[0])) {
        $("." + monitorings[0].levelClass).text(content.level);
        $("." + monitorings[0].suggestClass).text(content.suggest);
      }
    }

  } else if (data.topic == monitorings[1].topic) {
    var messages = data.message.split(",");
    var labels = [];
    var total = 0;
    var amount = messages.length;

    for (var i = 0; i < amount; i++) {
      total += tryParseInt(messages[i], 0);
      labels[i] = monitorings[1].chartLabel + (i + 1);
    }

    var temp = (amount) ? Math.round(total / amount) : 0;

    monitorings[1].gauge.refresh(temp);
    monitorings[1].chart.data.labels = labels;
    monitorings[1].chart.data.datasets[0].data = messages.map(Number);
    monitorings[1].chart.update();

    for (var content of monitorings[1].contents) {
      if ((temp < content.value[1]) &&
        (temp >= content.value[0])) {
        $("." + monitorings[1].levelClass).text(content.level);
        $("." + monitorings[1].suggestClass).text(content.suggest);
      }
    }

  } else if (data.topic == monitorings[2].topic) {
    var messages = data.message.split(",");
    var den = tryParseInt(messages[0], 0);
    var num = tryParseInt(messages[1], 0);
    var light = (den) ? Math.round(num * 100 / den) : 0;

    $("." + monitorings[2].lightBeforeClass).text(den);
    $("." + monitorings[2].lightAfterClass).text(num);
    monitorings[2].gauge.refresh(light);

    for (var content of monitorings[2].contents) {
      if ((light < content.value[1]) &&
        (light >= content.value[0])) {
        $("." + monitorings[2].levelClass).text(content.level);
        $("." + monitorings[2].suggestClass).text(content.suggest);
      }
    }
  }
});

function tryParseInt(str, defaultValue) {
  if (/^\d+$/g.test(str) === true)
    return parseInt(str);
  return defaultValue;
}

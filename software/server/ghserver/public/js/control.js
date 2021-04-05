control = {
  topic: "phatvu1294/ghsystem/",
  buttonsClass: ["switch-toggle", "switch-apply"],
  inputsId: ["settemp"],
  on: {
    state: "1",
    text: "Bật"
  },
  off: {
    state: "0",
    text: "Tắt"
  }
};

var socket = io();

socket.on("server-control-firstload", function(data) {
  for (var publish of data) {
    var param = publish.topic.split("/");

    if ($("." + param[2]).hasClass(control.buttonsClass[0])) {
      $("." + param[2]).text(control.on.text).addClass(control.on.state);

      if (publish.message == control.on.state) {
        $("." + param[2]).text(control.off.text).addClass(control.off.state).removeClass(control.on.state);
      } else if (publish.message == control.off.state) {
        $("." + param[2]).text(control.on.text).addClass(control.on.state).removeClass(control.off.state);
      }

    } else if ($("." + param[2]).hasClass(control.buttonsClass[1])) {
      $("#" + param[2]).val(tryParseInt(publish.message, 30));
    }
  }
});

$("." + control.buttonsClass[0]).click(function(evt) {
  evt.preventDefault();
  var param = $(this).attr("class").split(" ");

  socket.emit("client-control-request", {
    topic: control.topic + param[1],
    message: param[2]
  });
});

$("." + control.buttonsClass[1]).click(function(evt) {
  evt.preventDefault();
  var param = $(this).attr("class").split(" ");

  socket.emit("client-control-request", {
    topic: control.topic + param[1],
    message: $("#" + param[1]).val()
  });
})

socket.on("server-control-response", function(data) {
  var param = data.topic.split("/");

  if ($("." + param[2]).hasClass(control.buttonsClass[0])) {
    if (data.message == control.on.state) {
      $("." + param[2]).text(control.off.text).addClass(control.off.state).removeClass(control.on.state);
    } else if (data.message == control.off.state) {
      $("." + param[2]).text(control.on.text).addClass(control.on.state).removeClass(control.off.state);
    }
  }
});

for (var inputId of control.inputsId) {
  $("#" + inputId).change(function() {
    $("#" + inputId).val(tryParseInt($("#" + inputId).val(), 0));
  })
}

function tryParseInt(str, defaultValue) {
  if (/^\d+$/g.test(str) === true)
    return parseInt(str);
  return defaultValue;
}

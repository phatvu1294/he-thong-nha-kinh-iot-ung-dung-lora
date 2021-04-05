var express = require("express");
var app = express();
var server = require("http").Server(app);
var io = require("socket.io")(server);
var mqtt = require("mqtt");
var bodyParser = require("body-parser");
var cors = require("cors");
var path = require("path");
var expressLayouts = require("express-ejs-layouts");
var wunderground = require("wunderground")("ad39585ec9063af1", "VU");
var schedule = require("node-schedule");

app.use(bodyParser.urlencoded({
  extended: true
}));
app.use(bodyParser.json());
app.use(cors());
app.use(expressLayouts);
app.use(express.static(path.join(__dirname, "public")));
app.set("views", path.join(__dirname, 'views'));
app.set("view engine", "ejs");

var store = {
  subscribes: [{
    topic: "phatvu1294/ghsystem/co2",
    message: "0"
  }, {
    topic: "phatvu1294/ghsystem/temp",
    message: "0"
  }, {
    topic: "phatvu1294/ghsystem/light",
    message: "0"
  }],

  publishs: [{
    topic: "phatvu1294/ghsystem/onoff1",
    message: "0"
  }, {
    topic: "phatvu1294/ghsystem/onoff2",
    message: "0"
  }, {
    topic: "phatvu1294/ghsystem/onoff3",
    message: "0"
  }, {
    topic: "phatvu1294/ghsystem/onoff4",
    message: "0"
  }, {
    topic: "phatvu1294/ghsystem/settemp",
    message: "30"
  }],

  forecast: [{}]
};

var client = mqtt.connect("mqtt://m21.cloudmqtt.com", {
  host: "m21.cloudmqtt.com",
  port: 18544,
  clientId: "mqttjs_" + Math.random().toString(16).substr(2, 8),
  username: "igidqkav",
  password: "HL21gpbm4N-p",
  keepalive: 60,
  reconnectPeriod: 1000,
  clean: true,
  encoding: "utf8"
});

wunderground.forecast({
  city: "Hanoi",
  state: "VN"
}, function(err, data) {
  if (!err) {
    store.forecast = data;
  }
});

io.on("connection", function(socket) {
  socket.emit("server-control-firstload", store.publishs);
  socket.emit("server-monitoring-firstload", store.subscribes);
  socket.emit("server-forecast-response", store.forecast);

  var j = schedule.scheduleJob("0 * * * *", function() {
    wunderground.forecast({
      city: "Hanoi",
      state: "VN"
    }, function(err, data) {
      if (!err) {
        store.forecast = data;
      }
    });

    io.emit("server-forecast-response", store.forecast);
  });

  for (var subscribe of store.subscribes) {
    client.subscribe(subscribe.topic, {
      qos: 0
    });
  }

  client.on("message", function(topic, message) {
    io.emit("server-monitoring-response", {
      topic: topic,
      message: message.toString()
    });

    for (var subscribe of store.subscribes) {
      if (topic == subscribe.topic) {
        subscribe.message = message.toString();
      }
    }
  });

  socket.on("client-control-request", function(data) {
    io.emit("server-control-response", {
      topic: data.topic,
      message: data.message
    });

    for (var publish of store.publishs) {
      if (data.topic == publish.topic) {
        if (data.message != publish.message) {
          client.publish(data.topic, data.message, {
            qos: 0,
            retain: true
          });
        }

        publish.message = data.message;
      }
    }
  });
});

app.get("/", function(req, res) {
  res.render("index", {
    page: "index"
  });
});

app.get("/monitoring", function(req, res) {
  res.render("monitoring", {
    page: "monitoring"
  });
});

app.get("/control", function(req, res) {
  res.render("control", {
    page: "control"
  });
});

app.get("/forecast", function(req, res) {
  res.render("forecast", {
    page: "forecast"
  });
});

app.get("/about", function(req, res) {
  res.render("about", {
    page: "about"
  });
});

server.listen(process.env.PORT || 3000);

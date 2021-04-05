var socket = io();

socket.on("server-forecast-response", function(data) {
  $(".forecast-wrapper").empty();
  for (var forecast of data.forecast.txt_forecast.forecastday) {
    $(".forecast-wrapper").append(
      "<div class=\"forecast\">" +
      "<div class=\"forecast-image\"><img src=\"" + forecast.icon_url + "\"/></div>" +
      "<div class=\"forecast-title\">" + forecast.title + "</div>" +
      "<div class=\"forecast-text\">" + forecast.fcttext_metric + "</div>" +
      "</div>"
    );
  }
  $(".forecast-update").html(
    "Cập nhật " + data.forecast.txt_forecast.date + " bởi <a href=\"" +
    data.response.termsofService +
    "\" target=\"_blank\">WUnderground</a>"
  );
});
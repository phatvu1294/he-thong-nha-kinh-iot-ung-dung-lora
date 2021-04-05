$(document).ready(function() {
  $(".navbar-toggle").click(function() {
    $(".navbar").toggleClass("active");
  });

  var sticky = $("#navbar-wrapper").offset().top;
  window.onscroll = function() {
    if (window.pageYOffset >= sticky) {
      $("#navbar-wrapper").addClass("sticky");
    } else {
      $("#navbar-wrapper").removeClass("sticky");
    }
  }
});
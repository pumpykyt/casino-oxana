function Refresh()
{

    var today = new Date();
  var h = today.getHours();
  var m = today.getMinutes();
  var s = today.getSeconds();
  // add a zero in front of numbers<10
  m = checkTime(m);
  s = checkTime(s);
  document.getElementById('current-time').innerHTML = h + ":" + m + ":" + s;
  console.log(h + ":" + m + ":" + s);
}
Refresh();
let timerId = setInterval(() => Refresh(), 1000);

function checkTime(i) {
    if (i < 10) {
      i = "0" + i;
    }
    return i;
  }

  function login_access()
  {

  }
  

  var app = angular.module("tabPanel",[]);

app.controller("headerCtrl", function($scope){
  $scope.header = 'Tab Widget Angular Style';
  $scope.mySite = "Petrus Rex";
});

app.controller("tabCtrl",function($scope){
    $scope.tabSelected = "#awesome1";
    $scope.tabChange = function(e){
        if (e.target.nodeName === 'A') {
            $scope.tabSelected = e.target.getAttribute("href");
            e.preventDefault();
        }
    }
});


function clickProfile(){
  var menu1 = document.getElementById("menu1");

  var menu2 = document.getElementById("menu2");
  var menu3 = document.getElementById("menu3");
  var menu4 = document.getElementById("menu4");

  menu1.classList.remove("fade");

  menu2.classList.add("fade");
  menu3.classList.add("fade");
  menu4.classList.add("fade");
}
  $('.slide-nav').on('click', function(e) {
    // get current slide
    var current = $('.flex-active').data('slide'),
      // get button data-slide
      next = $(this).data('slide');
  
    $('.slide-nav').removeClass('active');
    $(this).addClass('active');
  
    if (current === next) {
      return false;
    } else {
      $('.slider-wrapper').find('.flex-container[data-slide=' + next + ']').addClass('flex-preStart');
      $('.flex-active').addClass('animate-end');
      setTimeout(function() {
        $('.flex-preStart').removeClass('animate-start flex-preStart').addClass('flex-active');
        $('.animate-end').addClass('animate-start').removeClass('animate-end flex-active');
      }, 800);
    }
  });

  

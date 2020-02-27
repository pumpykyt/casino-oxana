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

  $('.slide-nav').on('click', function(e) {
    e.preventDefault();
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

  
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
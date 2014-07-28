window.addEventListener('click', function (e) {
    var x = e.clientX;
    var y = e.clientY;

    var time = new Date();

    document.getElementById('result').innerText += "X:" + x + "; Y:" + y + " Time: " + time;
    document.getElementById('result').innerHTML += '</br>';
}, false);

var button = document.getElementById('btnHideOddRows');
button.onclick = function ()
{
    var rows = document.getElementsByTagName('tr');
    for (var i = 0; i < rows.length; i++) {
        if (i == 1) {
            var element = rows[i];
            element.parentNode.removeChild(element);
            continue;
        }
        if ((i + 1) % 2 !== 0) {
            var element = rows[i];
            element.parentNode.removeChild(element);
        }
    }
};


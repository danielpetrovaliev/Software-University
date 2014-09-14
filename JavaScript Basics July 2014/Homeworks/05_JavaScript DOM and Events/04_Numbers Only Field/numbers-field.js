var input = document.getElementById('number');

function check() {

    var value = document.getElementById('number').value;

    if (isNaN(value)) {
        document.getElementById('number').style.backgroundColor = "red";
    }

}

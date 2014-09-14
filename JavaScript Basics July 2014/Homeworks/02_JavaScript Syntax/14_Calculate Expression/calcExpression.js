function calcExpression() {


    var input = document.getElementById("exp").value;

    var result = eval(input);
    document.getElementById("result").innerHTML = result.toString();

}
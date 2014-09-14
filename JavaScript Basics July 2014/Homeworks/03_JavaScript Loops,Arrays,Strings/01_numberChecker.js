function printNumbers(n) {
    var input = "";

    // make string with ","
    for (var i = 2; i <= n; i++) {
        if ((i % 4 !== 0) && (i % 5 !== 0)) {
            input = input + i + ",";

        }

    }

    //remove last ","
    var output = "";
    for (var i = 0; i <= input.length-2; i++) {
        output+= input[i];
    }

    if(n===1 || n===0){
        output = 'no';
    }

    return output;
}


console.log(printNumbers(20));
console.log(printNumbers(1));
console.log(printNumbers(13));
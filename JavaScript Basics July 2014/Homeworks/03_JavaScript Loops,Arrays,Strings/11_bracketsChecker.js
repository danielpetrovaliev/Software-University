function checkBrackets(input) {

    var openBracketCount = 0;
    var closeBracketCount = 0;
    var output = '';

    for (var i = 0; i < input.length; i++) {
        if (input[i] === '(') {
            openBracketCount++;
        }

        else if (input[i] === ')') {
            closeBracketCount++;
        }
    }

    if (openBracketCount === closeBracketCount) {
        output = 'correct'
    }
    else {
        output = 'incorrect';
    }

    return output;
}

console.log(checkBrackets('( ( a + b ) / 5 – d )'));
console.log(checkBrackets(') ( a + b ) )'));
console.log(checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));
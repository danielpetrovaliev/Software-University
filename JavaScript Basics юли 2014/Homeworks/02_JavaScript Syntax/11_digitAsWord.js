function convertDigitToWord(value){

    var output = " ";

    switch (value) {
        case 1:
            output = "one";
            break;
        case 2:
            output = "two";
            break;
        case 3:
            output = "three";
            break;
        case 4:
            output = "four";
            break;
        case 5:
            output = "five";
            break;
        case 6:
            output = "six";
            break;
        case 7:
            output = "seven";
            break;
        case 8:
            output = "eight";
            break;
        case 9:
            output = "nine";
            break;
    }

    return output;

}

console.log(convertDigitToWord(8));
console.log(convertDigitToWord(3));
console.log(convertDigitToWord(5));
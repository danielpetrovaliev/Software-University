function findNthDigit(input) {

    var nThDigit = Number(input[0]);
    var number =  input[1].toString().replace(".", "").split("");
    var digit = number[number.length - nThDigit];

    if (digit === undefined) {
        digit = "The number doesn’t have 6 digits";
    }
    return digit;

}
console.log(findNthDigit([1, 6]));
console.log(findNthDigit([2, -55]));
console.log(findNthDigit([6, 923456]));
console.log(findNthDigit([3, 1451.78]));
console.log(findNthDigit([6, 888.88]));
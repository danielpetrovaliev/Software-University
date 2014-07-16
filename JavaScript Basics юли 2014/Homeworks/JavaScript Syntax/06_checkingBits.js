function bitChecker(value) {
    var bin = value.toString(2);
    var isOne = false;
    if (parseInt(bin.charAt(bin.length - 4)) === 1) {
        isOne = true;
    }
    return isOne;
}

console.log(bitChecker(333));
console.log(bitChecker(425));
console.log(bitChecker(2567564754));
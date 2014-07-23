function checkDigit(value){
    value = value.toString();
    var isDigit3 = true;
    if (parseInt(value.charAt(value.length - 3)) !== 3) {
        isDigit3 = false;
    }
    return isDigit3;
}

console.log(checkDigit(1235));
console.log(checkDigit(25368));
console.log(checkDigit(123456));
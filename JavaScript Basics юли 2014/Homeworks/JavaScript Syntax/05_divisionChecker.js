function divisionBy3(value) {
    var sum = 0;
    var answer = '';
    var str = value.toString();

    for (var i = 0; i <= str.length - 1; i++) {
        sum += parseInt(str.charAt(i));
    }

    if (sum % 3 === 0) {
        answer = 'the number is divided by 3 without remainder';
    }
    else {
        answer = 'the number is not divided by 3 without remainder';
    }

    return answer;
}

console.log(divisionBy3(12));
console.log(divisionBy3(189));
console.log(divisionBy3(591));
console.log(divisionBy3(188));
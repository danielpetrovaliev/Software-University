function reverseString(input) {

    var reversedString = '';
    var str = input.split("");
    str.reverse();

    for (var i = 0; i < str.length; i++) {
        reversedString += str[i];

    }

    return reversedString;
}

console.log(reverseString('sample'))
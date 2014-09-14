function reverseWordsInString(str) {

    var input = str.split(" ");
    var reversedArray = [];

    for (var i = 0; i < input.length; i++) {
        reversedArray[i] =input[i].split("").reverse().join("");
    }

    var output = reversedArray.join(" ");

    return output;
}

console.log(reverseWordsInString("Hello, how are you."));
console.log(reverseWordsInString("Life is pretty good, isn’t it?"));
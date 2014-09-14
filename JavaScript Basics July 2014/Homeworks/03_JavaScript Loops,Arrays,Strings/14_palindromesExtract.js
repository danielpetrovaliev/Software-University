function findPalindromes(input) {

    var splitedWords = input.toLowerCase().split(/\W+/);
    splitedWords.splice(splitedWords.length-1, splitedWords.length);
    var rightCharCounter = 0;
    var leftCharCounter = 0;
    var equalCounter = 0;
    var palindromes = "";

    //check word
    for (var i = 0; i < splitedWords.length; i++) {

        rightCharCounter = splitedWords[i].length-1;

        //check char
        for (var j = 0; j < splitedWords[i].length/2; j++) {
            if (splitedWords[i][j] === splitedWords[i][rightCharCounter]) {
                equalCounter++;
            }
            rightCharCounter--;
        }

        //check is palindrom
        if (equalCounter === Math.round(splitedWords[i].length/2)) {
            if (palindromes === "") {
                palindromes += splitedWords[i]
            }
            else{
                palindromes = palindromes +", " + splitedWords[i];
            }

        }

        equalCounter = 0;

    }

    return palindromes;

}

console.log(findPalindromes('There is a man, his name was Bob.'));
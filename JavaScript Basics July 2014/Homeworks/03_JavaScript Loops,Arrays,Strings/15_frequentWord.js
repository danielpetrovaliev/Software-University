function findMostFreqWord(input) {

    var splitedInput = input.toLocaleLowerCase().split(/\W+/);
    var currFrequent = 0;
    var mostFrequent = 0;
    var currWord = "";
    var mostFrequentsWords = new Object({});
    var output = "";
    //remove empty str
    if (splitedInput[splitedInput.length-1] == "") {
        splitedInput.splice(splitedInput.length-1, splitedInput.length);
    }

    for (var i = 0; i < splitedInput.length; i++) {
        for (var j = i; j < splitedInput.length; j++) {
            if (splitedInput[i] === splitedInput[j]) {
                currFrequent++;
                currWord = splitedInput[i];
                if (currFrequent > mostFrequent) {
                    mostFrequent = currFrequent;

                }
                if (j > currFrequent+1 && currFrequent === mostFrequent) {
                    currWord = splitedInput[i];
                    output += currWord + " -> " + currFrequent + " times\n";
                }
            }

        }

        currFrequent = 0;

    }

    return output;
}

console.log(findMostFreqWord('in the middle of the night'));
console.log(findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.'));
console.log(findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.'));
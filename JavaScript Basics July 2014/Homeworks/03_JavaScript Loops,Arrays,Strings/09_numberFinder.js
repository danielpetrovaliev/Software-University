function findMostFreqNum(input) {

    var mostFrequentCounter = 0;
    var currFrequentCounter = 0;
    var currIndex = 0;
    var output = "";

    for (var i = 0; i < input.length; i++) {
        for (var j = i; j < input.length; j++) {
            if (input[i] === input[j]) {
                currFrequentCounter++;
                if (currFrequentCounter > mostFrequentCounter) {
                    mostFrequentCounter = currFrequentCounter;
                    currIndex = input[i];
                }
            }

        }

        currFrequentCounter = 0;
    }

    output = currIndex +" (" + mostFrequentCounter + " times" + ")"

    return output;

}


console.log(findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]));
console.log(findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]));
console.log(findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]));
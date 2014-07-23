function findMaxSequense(input) {

    var maxSequence = 0;
    var currSequence = 0;
    var currIndex = input[0];
    var output = [];
    var i = 1;
    if (input.length === 1) {
        i = 0;
    }

    for (i ; i <= input.length-1; i++) {
        if (input.length === 1) {
            maxSequence = 1;
            continue;
        }
        if (input[i-1] === input[i]) {
            currSequence++;
            if (currSequence > maxSequence) {
                maxSequence = currSequence;
                currIndex = input[i];
            }
            if (currSequence === maxSequence) {
                currIndex = input[i];
            }

        }
        else {
            currSequence = 1;
        }
    }

    for (var i = 0; i < maxSequence; i++) {
        output.push(currIndex);
    }

    return output;
}


console.log(findMaxSequense([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(findMaxSequense(['happy']));
console.log(findMaxSequense([2, 'qwe', 'qwe', 3, 3, '3']));
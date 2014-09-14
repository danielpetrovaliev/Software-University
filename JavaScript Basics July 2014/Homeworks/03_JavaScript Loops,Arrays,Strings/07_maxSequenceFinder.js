function findMaxSequence(input) {

    var maxSequence = 0;
    var currSequence = 0;
    var currIndex = input[0];
    var output = [];


    for (var i = 1 ; i <= input.length-1; i++) {
        if (input[i-1] < input[i]) {
            currSequence++;
            if (currSequence > maxSequence) {
                maxSequence = currSequence;
                output.push(input[i-1]);
            }
            if (input[i] > input[i+1]) {
                output.push(input[i]);
            }

            if (i === input.length-1 && input[i-1] < input[i]) {
                output.push(input[i]);
            }
        }
        else {
            currSequence = 1;
        }
    }

    if (maxSequence === 0) {
        output = "no";
    }

    return output;
}

console.log(findMaxSequence([3, 2, 3, 4, 2, 2, 4]));
console.log(findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]));
console.log(findMaxSequence([3, 2, 1]));
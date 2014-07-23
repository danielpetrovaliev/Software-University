function findMinAndMax(number) {
    var maxNumber = Number.MIN_VALUE;
    var minNumber = Number.MAX_VALUE;

    for (var i = 0; i <= number.length-1; i++) {
        if (number[i]>maxNumber) {
            maxNumber = number[i];
        }
        else if (number[i] < minNumber) {
            minNumber = number[i];
        }
    }

    var output = "Min -> " + minNumber +"\nMax -> " + maxNumber;

    return output;
}

console.log(findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]));
console.log(findMinAndMax([2, 2, 2, 2, 2]));
console.log(findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]));
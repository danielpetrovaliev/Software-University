function findLargestBySumOfDigits(input) {

    var maxSum = Number.MIN_VALUE;
    var currNum = "";
    var maxSumNum = "";
    var currSum = 0;


    for (var i = 0; i < arguments.length; i++) {
        var currNum = arguments[i].toString();
        for (var j = 0; j < currNum.length; j++) {
            currSum += Number(currNum[j]);
        }
        if (currSum > maxSum) {
            maxSum = currSum;
            maxSumNum = arguments[i];
        }
        if (isNaN(currSum)) {
            return undefined;
        }
        currSum = 0;
    }

    return maxSumNum;


    
}

console.log(findLargestBySumOfDigits(5, 10, 15, 111));
console.log(findLargestBySumOfDigits(33, 44, 99, 0, 20));
console.log(findLargestBySumOfDigits('hello'));
console.log(findLargestBySumOfDigits(5, 3.3));

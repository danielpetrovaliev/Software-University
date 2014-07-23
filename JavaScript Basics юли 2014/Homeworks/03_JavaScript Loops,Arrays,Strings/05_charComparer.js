function compareChars(firstArr, secondArr) {

    var isEqually = true;
    var output = "";
    for (var i = 0; i <= firstArr.length-1; i++) {
        if (firstArr[i] != secondArr[i]){
            isEqually = false;
            break;
        }
    }

    if (isEqually) {
        output = "Equal";
    }

    else {
        output = "Not Equal";
    }

    return output;
}

console.log(compareChars(['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'], ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']));
console.log(compareChars(['3', '5', 'g', 'd'], ['5', '3', 'g', 'd']));
console.log(compareChars(['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'], ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']));

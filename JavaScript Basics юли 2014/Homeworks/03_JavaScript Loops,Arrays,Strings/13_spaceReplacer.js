function replaceSpaces(input) {

    var arr = [];
    var output = "";

    //Adding input to new array
    for (var i = 0; i < input.length; i++) {
        arr.push(input[i]);

    }

    //Replace white spaces
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] === " ") {
            arr[i] = "";
        }
    }

    //Add array to string
    for (var i = 0; i < arr.length; i++) {
        output += arr[i]
    }


    return output;
}


console.log(replaceSpaces("But you were living in another world tryin' to get your message through"));
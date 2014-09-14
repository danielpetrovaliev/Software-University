function createArray() {
    var arrOf20integers = new Array(20);

    for (var i = 0; i < arrOf20integers.length - 1; i++) {
        arrOf20integers[i] = i*5;
    }

    return arrOf20integers;
}

console.log(createArray());
function evenNumber(value) {
    value = value % 2 === 0;
    return value;
}

console.log(evenNumber(3));
console.log(evenNumber(127));
console.log(evenNumber(588));
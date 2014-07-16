function calcSupply(age, maxAge, foodPerDay) {
    var foodPerYears = ((maxAge - age) * 365) * foodPerDay;

    return foodPerYears;
}

console.log(calcSupply(38 , 118, 0.5) + "kg of chocolate would be enough until I am 118 years old.");
console.log(calcSupply(20, 87, 2) + "kg of fruits would be enough until I am 87 years old.");
console.log(calcSupply(16, 102, 1.1) +"kg of nuts would be enough until I am 102 years old.");
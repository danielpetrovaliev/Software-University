function calcCylinderVol(radius, height) {
    var volume = Math.PI * radius*radius * height;

    return Math.round(volume * 1000) /1000;
}

console.log(calcCylinderVol(2, 4));
console.log(calcCylinderVol(5, 8));
console.log(calcCylinderVol(12, 3));
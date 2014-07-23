function isPrime(value) {
    var prime = true;
    for (var i = 2; i <= value; i++) {
        if (value % i === 0) {
            if (value === i) {
                continue;
            }
            prime = false;
        }
    }
    return prime;
}

console.log(isPrime(7));
console.log(isPrime(254));
console.log(isPrime(587));
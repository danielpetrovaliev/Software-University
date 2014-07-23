function findCardFrequency(input) {

    var splitedCards = input.split(/\W+/);
    var resultCard = {};
    var output = '';

    //remove empty str
    if (splitedCards[splitedCards.length-1] == "") {
        splitedCards.splice(splitedCards.length-1, splitedCards.length);
    }


    for (var i in splitedCards) {
        if (splitedCards[i] in resultCard) {
            var strr = splitedCards[i]+"";
            resultCard[strr]++; // if exist, frequencies is + 1
        } else {
            var str = splitedCards[i]+"";
            resultCard[str] = 1; // if not exist, create new instance equals to 1
        }
    }


    for (var obj in resultCard) {
        output += obj + " -> " + (((resultCard[obj] / splitedCards.length)*100).toFixed(2)) + "%\n";
    }
    console.log(resultCard);

    return output;

}

console.log(findCardFrequency('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦'));
console.log(findCardFrequency('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠'));
console.log(findCardFrequency('10♣ 10♥'));
function countOfDivs(input) {

    var counter = 0;

    var str = "<div";
    for (var i = 0; i < input.length; i++) {
        if (str[0] == input[i] && str[1] == input[i+1] && str[2] == input[i+2] && str[3] == input[i+3]) {
            counter++;
        }
    }
    return counter;
}

console.log(countOfDivs('<!DOCTYPE html><html><head lang="en"><meta charset="UTF-8"><title>index</title><script src="/yourScript.js" defer></script></head><body><div id="outerDiv"><div class="first"><div><div>hello</div></div></div><div>hi<div></div></div><div>I am a div</div></div></body></html>'));
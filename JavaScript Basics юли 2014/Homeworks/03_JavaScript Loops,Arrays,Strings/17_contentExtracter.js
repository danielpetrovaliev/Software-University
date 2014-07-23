function ectractContent(input) {


    var removeTags = input.match(/>[^><]+</g).toString();
    var removeBrackets = removeTags.replace(/[<>\s]/g, "").replace(",", "");
    var output = removeBrackets;


    return output;
}

console.log(ectractContent("<p>Hello</p><a href='http://w3c.org'>W3C</a>"));
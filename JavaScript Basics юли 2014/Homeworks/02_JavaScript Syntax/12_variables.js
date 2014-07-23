function variablesTypes(input) {
    var name = "My name: " +input[0] + " //type is " + typeof(input[0]);
    var age = "My age: " + input[1] + " //type is " + typeof(input[1]);
    var isMale = "I am male: " + input[2] + " //type is " + typeof(input[2]);
    var favoriteFoods = "My favorite foods are: " + input[3].toString() + " //type is "+typeof(input[3]);
    var output = '"'+name + " \n" + age + "\n" + isMale + '\n' + favoriteFoods + '"';

    return output;
}

console.log(variablesTypes(['Pesho', 22, true, ['fries', 'banana', 'cake']]));
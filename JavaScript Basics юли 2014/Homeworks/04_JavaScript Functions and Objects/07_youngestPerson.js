function findYoungestPerson(persons) {

    var currPerson;
    var youngestPerson = Number.MAX_VALUE;
    var output = "";

    for (var i = 0; i < persons.length; i++) {
        currPerson = persons[i].age;
        if (!persons[i].age) {
            continue;
        }
        if (currPerson < youngestPerson) {
            youngestPerson = currPerson;
            output = "The youngest person is " + persons[i].firstname + " " + persons[i].lastname;
        }

    }

    return output;

}

console.log(findYoungestPerson([
    { firstname : 'George', lastname: 'Kolev', age: 32},
    { firstname : 'Bay', lastname: 'Ivan', age: 81},
    { firstname : 'Baba', lastname: 'Ginka', age: 40}]));
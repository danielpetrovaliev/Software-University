function soothsayer(years, language, city, car) {

    var result = [years[1], language[3], city[4], car[4]];

    return "You will work " + result[0] + " years on " + result[1] + ".\nYou will live in " + result[2] + " and drive " + result[3] + ".";
}

console.log(soothsayer([3, 5, 2, 7, 9], ["Java", "Python", "C#", "JavaScript", "Ruby"],
    ["Silicon Valley","London", "Las Vegas", "Paris", "Sofia"],["BMW","Audi","Lada","Skoda","Opel"]));
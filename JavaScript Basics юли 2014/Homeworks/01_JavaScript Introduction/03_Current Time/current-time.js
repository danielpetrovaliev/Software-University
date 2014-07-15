var dateNow = new Date();
var hours = dateNow.getHours();
var minutes = dateNow.getMinutes();


if (hours<10) {
    hours = "0" + hours;
}

if (minutes<10) {
    minutes = "0" + minutes;
}
console.log(hours + ":" + minutes);
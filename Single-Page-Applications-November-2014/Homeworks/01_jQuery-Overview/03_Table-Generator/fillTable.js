/**
 * Created by petrovaliev95 on 19-Nov-14.
 */
(function() {
    var cars = [{"manufacturer":"BMW","model":"E92 320i","year":2011,"price":50000,"class":"Family"},
    {"manufacturer":"Porsche","model":"Panamera","year":2012,"price":100000,"class":"Sport"},
    {"manufacturer":"Peugeot","model":"305","year":1978,"price":1000,"class":"Family"}];


    $(document).ready(function () {
        $('#process').on('click', fillTable);
    });

    function fillTable(){
        $(cars).each(function (_, car) {
           $('tbody')
                .append(
                    ($('<tr>').append($('<td>').html(car.manufacturer)))
                    .append($('<td>').html(car.model))
                    .append($('<td>').html(car.year))
                    .append($('<td>').html(car.price))
                    .append($('<td>').html(car.class))
                );
        });
    }

}());
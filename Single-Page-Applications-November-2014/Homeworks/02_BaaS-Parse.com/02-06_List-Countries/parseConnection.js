/**
 * Created by petrovaliev95 on 21-Nov-14.
 */
(function() {
    var listITownTemplate =
        '<div class="col-md-12 list-item-container">' +
            '<li class="list-group-item col-md-6">{{ListText}}</li>' +
            '<button class="edit custom-button btn btn-info text-center col-md-2 col-md-offset-1">' +
                '<span class="glyphicon glyphicon-pencil"></span> Edit' +
            ' </button>' +
            '<button class="remove custom-button btn btn-danger col-md-1"> ' +
                '<span class="glyphicon glyphicon-remove"></span>' +
            '</button>' +
        '</div>';

    var listCountryTemplate =
        '<div class="col-md-12 list-item-container">' +
            '<li class="list-group-item col-md-6">{{ListText}}</li>' +
            '<button class="edit custom-button btn btn-info text-center col-md-2 col-md-offset-1">' +
                '<span class="glyphicon glyphicon-pencil"></span> Edit' +
            ' </button>' +
            '<button class="add-town custom-button btn btn-success text-center col-md-2 col-md-offset-1">' +
                '<span class="glyphicon glyphicon-plus"></span> Town' +
            ' </button>' +
            '<button class="remove custom-button btn btn-danger col-md-1"> ' +
                '<span class="glyphicon glyphicon-remove"></span>' +
            '</button>' +
        '</div>';

    $.ajaxSetup({
        headers: {
            "X-Parse-Application-Id": "PRaxor1f7zUilpO4Avg5Wj5SMwn27kqlcvODO0zz",
            "X-Parse-REST-API-Key": "klcev3mujMsnyclr6awnen7ngYBo5pfKxQNv6rEX"
        }
    });

    $(function () {
        updateCountries();
        updateTowns();
    });
    
    function updateCountries(){
        $.ajax({
            method: "GET",
            url: "https://api.parse.com/1/classes/Country",
            success: [getCountries, drawCountriesInSelect],
            error: errorLoadData
        });
    }

    function updateTowns(){
        $.ajax({
            method: "GET",
            url: "https://api.parse.com/1/classes/Town",
            success: getTowns,
            error: errorLoadData
        });
    }

    function getCountries(data){
        $('#countries').children().remove();
        var countries = data.results;
        if (countries.length > 0) {
            $(countries).each(function (_, country) {
                var currentTemplate = listCountryTemplate.replace('{{ListText}}', country.name);
                currentTemplate = $.parseHTML(currentTemplate);
                $(currentTemplate).data('country', country);
                $('#countries').append(currentTemplate);
            });
            $('#countries').find('.remove').off().click(function () {
                var country = $(this).parent().data('country');
                $.ajax({
                    method: 'DELETE',
                    url: 'https://api.parse.com/1/classes/Country/' + country.objectId
                });
                var $this = $(this);
                $this.parent().remove();
            });
            $('#countries').find('.edit').off().click(function () {
                var country = $(this).parent().data('country');
                modal({
                    type  : 'prompt',
                    title : 'Edit Country name',
                    text  : "Name: ",
                    theme : 'atlant',
                    callback : editCountry
                });
                function editCountry(newCountryName){
                    if (newCountryName) {
                        $.ajax({
                            method: 'PUT',
                            url: 'https://api.parse.com/1/classes/Country/' + country.objectId,
                            data: JSON.stringify(
                                {'name': newCountryName}
                            ),
                            contentType: "application/json",
                            success: updateCountries,
                            error: errorLoadData
                        });
                    } else{
                        errorLoadData();
                    }
                }
            });
            $('#countries').find('.add-town').off().click(function () {
                var country = $(this).parent().data('country');
                modal({
                    type  : 'prompt',
                    title : 'Add Town to this Country',
                    text  : "Name: ",
                    theme : 'atlant',
                    callback : addTownToCountry
                });
                function addTownToCountry(newTown){
                    if (newTown) {
                        $.ajax({
                            method: 'POST',
                            url: 'https://api.parse.com/1/classes/Town',
                            data: JSON.stringify(
                                {
                                    'name': newTown,
                                    'country' : {
                                        "__type": "Pointer",
                                        "className": "Country",
                                        "objectId": country.objectId
                                    }
                                }
                            ),
                            contentType: "application/json",
                            success: updateTowns,
                            error: errorLoadData
                        });
                    } else{
                        errorLoadData();
                    }
                }
            });
        } else {
            $('#countries').append($('<li class="list-group-item list-group-item-danger">').text('No Results.'))
        }
    }

    function getTowns(data){
        $('#towns').children().remove();
        var countries = data.results;
        if (countries.length > 0) {
            $(countries).each(function (_, town) {
                var currentTemplate = listITownTemplate.replace('{{ListText}}', town.name);
                currentTemplate = $.parseHTML(currentTemplate);
                $(currentTemplate).data('town', town);
                $('#towns').append(currentTemplate);
            });
            $('#towns').find('.remove').off().click(function () {
                var town = $(this).parent().data('town');
                $.ajax({
                    method: 'DELETE',
                    url: 'https://api.parse.com/1/classes/Town/' + town.objectId
                });
                var $this = $(this);
                $this.parent().remove();
            });
            $('#towns').find('.edit').off().click(function () {
                var town = $(this).parent().data('town');
                modal({
                    type  : 'prompt',
                    title : 'Edit town name',
                    text  : "Name: ",
                    theme : 'atlant',
                    callback : editTown
                });
                function editTown(newTownName){
                    if (newTownName) {
                        $.ajax({
                            method: 'PUT',
                            url: 'https://api.parse.com/1/classes/Town/' + town.objectId,
                            data: JSON.stringify(
                                {'name': newTownName}
                            ),
                            contentType: "application/json",
                            success: updateTowns,
                            error: errorLoadData
                        });
                    } else{
                        errorLoadData();
                    }
                }
            });
        } else {
            $('#towns').append($('<li class="list-group-item list-group-item-danger">').text('No Results.'))
        }
    }

    function errorLoadData(){
        $(function () {
            modal({
                type: 'alert',
                title: 'Error!',
                text: 'Problem with connection with database.'
            });
        })
    }

    function uploadCountry(countryName) {
        if (countryName) {
            $.ajax({
                method: "POST",
                url: "https://api.parse.com/1/classes/Country",
                data: JSON.stringify(
                    {'name': countryName}
                ),
                success: updateCountries,
                contentType: "application/json",
                error: errorLoadData
            })
        } else{
            errorLoadData();
        }

    }

    function drawCountriesInSelect(data){
        var countries = data.results;
        $('#by-country').children().remove();
        $(countries).each(function (_, country) {
            $('#by-country').append($('<option>').attr('value', country.objectId).text(country.name).data('country', country));
        });
        $('#by-country').on('change', function () {
            var id = $(this).val();
            $.ajax({
                method: "GET",
                url: 'https://api.parse.com/1/classes/Town?where={"country":{"__type":"Pointer","className":"Country","objectId":"' + id + '"}}',
                success: drawTownsByCountry,
                error: errorLoadData
            })
        });

        function drawTownsByCountry(data){
            $('#towns-by-country').children().remove();
            var towns = data.results;

            if (towns.length > 0) {
                $(towns).each(function (_, town) {
                    $('#towns-by-country').append($('<li class="list-group-item">').text(town.name))
                })
            } else{
                $('#towns-by-country').append($('<li class="list-group-item list-group-item-danger">').text('No Results.'))
            }
        }
    }

    $(function () {
        $('#add-country').click(function () {
            modal({
                type  : 'prompt',
                title : 'Add Country',
                text  : "Name: ",
                theme : 'atlant',
                callback : uploadCountry
            });
        });
    });

    $(function () {
        $.ajax({
            method: "GET",
            url: "https://api.parse.com/1/classes/Country",
            success: drawCountriesInSelect,
            error: errorLoadData
        });
    })

}());
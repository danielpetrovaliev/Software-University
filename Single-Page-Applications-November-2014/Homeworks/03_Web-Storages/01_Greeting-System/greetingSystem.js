/**
 * Created by petrovaliev95 on 27-Nov-14.
 */
(function() {

    $(function () {
        if (localStorage.getItem('name')) {
            var name;
            name = localStorage.getItem('name');

            $('#greeting-form')
                .children()
                .remove();

            $('#greeting-form')
                .append($('<h1>').text('Hello ' + name + ' !'))
        }

        $('#set-name-to-local-storage').on('click', function () {
            var currName = $('#name').val();
            localStorage.setItem('name', currName);
            location.reload();
        })
    });

    function incrementLoads() {

        // Sesion storage counter
        if (!sessionStorage.getItem('sessionVisitCounter')) {
            sessionStorage.setItem('sessionVisitCounter', 0);
        }
        var sessionVisitCount = parseInt(sessionStorage.getItem('sessionVisitCounter'));
        sessionVisitCount += 1;
        sessionStorage.setItem('sessionVisitCounter', sessionVisitCount);
        $('#sessionCountDiv').text('Session visit count: ' + sessionVisitCount);

        //Local storage counter
        if (!localStorage.getItem('localVisitCounter')) {
            localStorage.setItem('localVisitCounter', 0);
        }
        var localVisitCount = parseInt(localStorage.getItem('localVisitCounter'));
        localVisitCount++;
        localStorage.setItem('localVisitCounter', localVisitCount);
        $('#localCountDiv').text('Local storage visit count: ' + localVisitCount);
    }

    $(function () {
        incrementLoads();
    });

}());
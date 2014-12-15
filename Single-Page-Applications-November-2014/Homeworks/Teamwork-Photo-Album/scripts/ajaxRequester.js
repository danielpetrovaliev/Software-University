/**
 * Created by petrovaliev95 on 27-Nov-14.
 */

var ajaxRequester = (function () {
    "use strict";

    var PARSE_APP_ID = "VakpEhaG1wVZTKI5dlWfMDFlU2Tfl7abmGUtCuKJ";
    var PARSE_REST_APP_KEY = "0YRvSq6Qc3tc5Py8Eui4Sn6ePuadvj9BFQgin2R2";

    $.ajaxSetup({
        headers: {
            "X-Parse-Application-Id": PARSE_APP_ID,
            "X-Parse-REST-API-Key": PARSE_REST_APP_KEY
        }
    });

    function makePostRequest(url, data, success, error) {
        $.ajax({
            type: 'POST',
            url: url,
            contentType: 'application/json',
            data: JSON.stringify(data),
            success: success,
            error: error
        });
    }

    function makePutRequest(url, data, success, error) {
        $.ajax({
            type: 'PUT',
            url: url,
            contentType: 'application/json',
            data: JSON.stringify(data),
            success: success,
            error: error
        });
    }

    function makeGetRequest(url, success, error) {
        $.ajax({
            type: 'GET',
            url: url,
            contentType: 'application/json',
            success: success,
            error: error
        });
    }

    function makeDeleteRequest(url, data, success, error) {
        $.ajax({
            type: 'DELETE',
            url: url,
            contentType: 'application/json',
            data: JSON.stringify(data),
            success: success,
            error: error
        });
    }


    return{
        post: makePostRequest,
        put: makePutRequest,
        get: makeGetRequest,
        delete: makeDeleteRequest
    }

}());
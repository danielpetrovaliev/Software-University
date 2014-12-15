var ajaxRequester = (function() {
	'use strict';

	var headers = {
		"X-Parse-Application-Id": "Ie6qBVpXofmhGEE3fpsMRXdGETxDo895EHOuWgQp",
		"X-Parse-REST-API-Key": "OPCwANU39mA3j0BdLLGRzOOEzCmTasqOW0rK8IkS"
	};

	function makeRequest(method, url, data, success, error) {
		if (sessionStorage['sessionKey']) {
			headers['X-Parse-Session-Token'] = sessionStorage.sessionKey;
		}
		$.ajax({
			url: url,
			method: method,
			headers: headers,
			contentType: 'application/json',
			data: JSON.stringify(data) || undefined,
			success: success,
			error: error
		});
	}


	function makeGetRequest(url, success, error) {
		return makeRequest('GET', url, null, success, error);
	}

	function makePostRequest(url, data, success, error) {
		return makeRequest('POST', url, data, success, error);
	}

	function makePutRequest(url, data, success, error) {
		return makeRequest('PUT', url, data, success, error);
	}

	function makeDeleteRequest(url, success, error) {
		return makeRequest('DELETE', url, null, success, error);
	}

	return {
		put: makePutRequest,
		get: makeGetRequest,
		post: makePostRequest,
		delete: makeDeleteRequest
	}

}());
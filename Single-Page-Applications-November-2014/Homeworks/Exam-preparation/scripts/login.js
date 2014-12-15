(function() {
	'use strict';

	$(function() {

		$('#login-button').on('click', login);

	});


	function login() {
		var username = $('#username').val();
		var password = $('#password').val();

		service.loginUser(username, password, loginSuccess, error);
	}

	function loginSuccess(data) {
		saveDataInStorage(data.username, data.sessionToken, data.objectId);
		$('#user').text(' - ' + data.username);
		$('#logout-btn').text('Logout').on('click', logout);
		noty({
			text: 'Login success.',
			type: 'success',
			layout: 'topCenter',
			timeout: 4000
		});
		window.location.hash = '#/bookmarks';
	}

	function logout (){
		sessionStorage.clear();
		$('#user').text('');
		$('#logout-btn').off().text();
		window.location.hash = '#/home';
	}

	function error(msg) {
		noty({
                text: msg.responseJSON.error,
                type: 'error',
                layout: 'topCenter',
                timeout: 4000}
        );
	}

	function saveDataInStorage (username, sessionKey, userId){
		sessionStorage.setItem('username', username);
		sessionStorage.setItem('sessionKey', sessionKey);
		sessionStorage.setItem('userId', userId);
	}

	// Debuging in chrome
	//# sourceURL=login.js

}());
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
			text: 'Login successful.',
			type: 'success',
			layout: 'topCenter',
			timeout: 2000
		});
		setTimeout(function() {
			goHomePage();
		}, 1000);
	}

	function logout() {
		sessionStorage.clear();
		$('#logout-button').off();
		noty({
			text: 'Logout successful.',
			type: 'success',
			layout: 'topCenter',
			timeout: 2000
		});
		setTimeout(function() {
			goHomePage();
		}, 1000);
	}

	function error(msg) {
		noty({
			text: msg.responseJSON.error,
			type: 'error',
			layout: 'topCenter',
			timeout: 4000
		});
	}

	function saveDataInStorage(username, sessionKey, userId) {
		sessionStorage.setItem('username', username);
		sessionStorage.setItem('sessionKey', sessionKey);
		sessionStorage.setItem('userId', userId);
	}

	function goHomePage() {
		location.reload();
		document.location.hash = '#/home';
	}

	// Debuging in chrome
	//# sourceURL=login.js

}());
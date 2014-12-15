(function () {
	'use strict';

	$(function() {

		$('#register-button').on('click', register);

	});

	function register (){
		var username = $('#username').val();
		var password = $('#password').val();
		service.registerUser(username, password, registerSuccess, error);
	}

	function registerSuccess(){
		noty({
			text: 'Registration success.',
			type: 'success',
			layout: 'topCenter',
			timeout: 4000
		});
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

	function saveDataInStorage (username, sessionKey){
		sessionStorage.setItem('username', username);
		sessionStorage.setItem('sessionKey', sessionKey);
	}

}());
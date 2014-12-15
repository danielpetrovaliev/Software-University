(function() {
	'use strict';

	$(function() {

		$('#register-button').on('click', register);

	});

	function register() {
		var username = $('#username').val();
		var password = $('#password').val();
		var confirmPassword = $('#confirm-password').val();

		// Validate all fields
		if (username && password && confirmPassword) {
			if (password === confirmPassword) {
				service.registerUser(username, password, registerSuccess, error);
			} else {
				noty({
					text: 'Passwords not match.',
					type: 'error',
					layout: 'topCenter',
					timeout: 4000
				});
			}
		} else {
			noty({
				text: 'All fields are rquired.',
				type: 'error',
				layout: 'topCenter',
				timeout: 3000
			});
		}

	}

	function registerSuccess() {
		noty({
			text: 'Registration success.',
			type: 'success',
			layout: 'topCenter',
			timeout: 2000
		});
		setTimeout(function() {
			goHomePage();
		}, 1000);
	}

	function goHomePage() {
		document.location.hash = '#/home';
	}

	function error(msg) {
		noty({
			text: msg.responseJSON.error,
			type: 'error',
			layout: 'topCenter',
			timeout: 4000
		});
	}

	// Debuging in chrome
	//# sourceURL=register.js

}());
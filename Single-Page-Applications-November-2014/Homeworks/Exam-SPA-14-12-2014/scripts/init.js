(function() {
	'use strict';


	$(function() {
		$(window).on('pageshow', function() {
			if (isLoggedIn()) {
				var currentUserName = sessionStorage.username;
				var currnentSessionKey = sessionStorage.sessionKey;

				$('#loggedOut-menu').hide();
				$('#loggedIn-menu').show();
				$('#greetings').text('Hi ' + currentUserName);
				$('#logout-button').on('click', logout);
			} else {
				$('#loggedOut-menu').show();
				$('#loggedIn-menu').hide();
			}
		});

	});

	function isLoggedIn(argument) {
		if (sessionStorage.username && sessionStorage.sessionKey) {
			return true;
		} else {
			return false;
		}
	}

	function logout() {
		sessionStorage.clear();
		$('#logout-button').off();
		noty({
			text: 'Logout successful.',
			type: 'success',
			layout: 'topCenter',
			timeout: 4000
		});
		setTimeout(function() {
			goHomePage();
		}, 1000);
	}

	function goHomePage() {
		location.reload();
		document.location.hash = '#/home';
	}

}());
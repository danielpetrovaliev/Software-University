(function() {
	'use strict';

	$(function() {
		var currentHash = window.location.hash;

		var sessionKey = sessionStorage.sessionKey;

		showContent();

		$(window).on('hashchange', function() {
			currentHash = window.location.hash;
			sessionKey = sessionStorage.sessionKey;
			showContent();
		});

		function showContent() {
			switch (currentHash) {
				case '#/login':
					$('#main').load('views/login.html');
					break;
				case '#/register':
					$('#main').load('views/register.html');
					break;
				case '#/products':
					if (sessionKey) {
						$('#main').load('views/products.html');
					} else {
						notLoggedInMessage();
					}
					break;
				case '#/home':
					$('#main').load('views/home.html');
					break;
				case '#/add-product':
					if (sessionKey) {
						$('#main').load('views/add-product.html');
					} else {
						notLoggedInMessage();
					};
					break;

				default: 
					$('#main').load('views/home.html');
					break;
			}
		}

		function notLoggedInMessage() {
			noty({
				text: 'You are not loggedIn.',
				type: 'error',
				layout: 'topCenter',
				timeout: 4000
			});
		}
	});

}());
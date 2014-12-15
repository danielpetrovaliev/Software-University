(function() {
	'use strict';

	$(function() {
		var currentHash = window.location.hash;

		showContent();

		$(window).on('hashchange', function() {
			currentHash = window.location.hash;
			showContent();
		});

		function showContent() {
			switch (currentHash) {
				case '#/login':
					$('#page-content').load('views/login.html');
					break;
				case '#/register':
					$('#page-content').load('views/register.html');
					break;
				case '#/bookmarks':
					$('#page-content').load('views/bookmarks.html');
					break;

				default:
					$('#page-content').load('views/home.html');
					break;
			}
		}
	});

}());
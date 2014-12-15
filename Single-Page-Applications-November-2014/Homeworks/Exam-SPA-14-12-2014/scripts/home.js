(function() {
	'use strict';

	if (sessionStorage.username && sessionStorage.sessionKey) {
		$('#welcome-user').show();
		$('#welcome-guest').hide();
		$('#welcome-user').find('#username').text(sessionStorage.username);
	} else {
		$('#welcome-user').hide();
		$('#welcome-guest').show();
	}

}());
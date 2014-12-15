var service = (function() {
	'use strict';

	var BASE_URL = 'https://api.parse.com/1';

	function registerUser(username, password, success, error) {
		var currUrl = BASE_URL + '/users';
		ajaxRequester.post(currUrl, {username: username, password: password}, success, error);
	}

	function loginUser(username, password, success, error) {
		var currUrl = BASE_URL + '/login' + '?username=' + username + '&password=' + password;
		ajaxRequester.get(currUrl, success, error);
	}

	function getBookmarks (success, error){
		var currUrl = BASE_URL + '/classes/Bookmark';
		ajaxRequester.get(currUrl, success, error);
	}

	function deleteBookmark (bookmarkId, success, error){
		var currUrl = BASE_URL + '/classes/Bookmark/' + bookmarkId;
		ajaxRequester.delete(currUrl, success, error);
	}

	function addBookmark(title, url, success, error){
		var currUrl = BASE_URL + '/classes/Bookmark';
		var userId = sessionStorage.getItem('userId');
		var bookmarkData = {
			title: title,
			url: url,
			ACL:{}
		};
		bookmarkData.ACL[userId] = {write:true,read:true};
		ajaxRequester.post(currUrl, bookmarkData, success, error);
	}

	return {
		loginUser: loginUser,
		registerUser: registerUser,
		getBookmarks: getBookmarks,
		deleteBookmark: deleteBookmark,
		addBookmark: addBookmark
	}
}());
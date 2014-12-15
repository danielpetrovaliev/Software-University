var service = (function() {
	'use strict';

	var BASE_URL = 'https://api.parse.com/1';

	function registerUser(username, password, success, error) {
		var currUrl = BASE_URL + '/users';
		ajaxRequester.post(currUrl, {
			username: username,
			password: password
		}, success, error);
	}

	function loginUser(username, password, success, error) {
		var currUrl = BASE_URL + '/login' + '?username=' + username + '&password=' + password;
		ajaxRequester.get(currUrl, success, error);
	}

	function getProducts(success, error) {
		var currUrl = BASE_URL + '/classes/Product';
		ajaxRequester.get(currUrl, success, error);
	}

	function deleteProduct(productId, success, error) {
		var currUrl = BASE_URL + '/classes/Product/' + productId;
		ajaxRequester.delete(currUrl, success, error);
	}

	function editProduct(productId, data, success, error) {
		var currUrl = BASE_URL + '/classes/Product/' + productId;
		ajaxRequester.put(currUrl, data, success, error);
	}

	function addProduct(name, category, price, success, error) {
		var currUrl = BASE_URL + '/classes/Product/';
		var userId = sessionStorage.getItem('userId');
		var productData = {
			name: name,
			category: category,
			price: price,
			ACL: {}
		};
		productData.ACL[userId] = {
			write: true,
			read: true
		};
		productData.ACL['*'] = {
			read: true
		};
		ajaxRequester.post(currUrl, productData, success, error);
	}

	return {
		loginUser: loginUser,
		registerUser: registerUser,
		getProducts: getProducts,
		deleteProduct: deleteProduct,
		addProduct: addProduct,
		editProduct: editProduct
	}
}());
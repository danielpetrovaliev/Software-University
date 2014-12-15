(function() {
	'use strict';

	$(function() {
		$('#add-product-button').on('click', addProduct);
	});


	function addProduct() {
		var productName = $('#name').val();
		var productCategory = $('#category').val();
		var productPrice = parseFloat($('#price').val()).toFixed(2);

		service.addProduct(productName, productCategory, productPrice, productAddedSuccessful, error);
	}


	function productAddedSuccessful() {
		noty({
			text: 'Product added successful.',
			type: 'success',
			layout: 'topCenter',
			timeout: 2000
		});
		setTimeout(function() {
			goToProducts();
		}, 2000);
	}

	function goToProducts() {
		//location.reload();
		document.location.hash = '#/products';
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
	//# sourceURL=add-product.js

}());
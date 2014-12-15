(function() {
	'use strict';

	var PRODUCT_BOX =
		'<li class="product">' +
		'<div class="product-info">' +
		'<p class="item-name">{{product-name}}</p>' +
		'<p class="category"><span class="pre">Category:</span> <span class="category-box">{{product-category}}</span></p>' +
		'<p class="price"><span class="pre">Price:</span> <span class="price-box">{{product-price}}</span></p>' +
		'</div>' +
		'<footer class="product-footer">' +
		'<a href="#/products">' +
		'<button class="edit-button">Edit</button>' +
		'</a>' +
		'<a href="#/products">' +
		'<button class="delete-button">Delete</button>' +
		'</a>' +
		'</footer>' +
		'</li>';

	$(function() {
		listAllProducts();
		getCategories();
		$('#edit-product-container').hide();
		$('#delete-product-container').hide();
		$('#filter').on('click', filterProducts);
		$('#clear-filters').on('click', clearFilters);
		$('.cancel-button').on('click', showProducts);
	});

	function listAllProducts() {
		service.getProducts(drawProducts, error);
	}

	function drawProducts(data) {
		var userId = sessionStorage.userId;
		$('#products-container').children().remove();
		$(data.results).each(function(_, product) {
			var $currProduct = $(PRODUCT_BOX
				.replace('{{product-name}}', escapeSpecialChars(product.name))
				.replace('{{product-category}}', escapeSpecialChars(product.category))
				.replace('{{product-price}}', escapeSpecialChars(product.price))
			);

			$currProduct.find('.edit-button').off().on('click', openEditWindow);
			$currProduct.find('.delete-button').off().on('click', openDeleteWindow);

			// check product owner
			if (!product['ACL'][userId]) {
				$currProduct.find('.product-footer').children().remove();
			}

			$currProduct.data('productData', product);
			$('#products-container').append($currProduct);
		})
	}

	function escapeSpecialChars(text) {
		return $('<span>').text(text).html()
	}


	function openEditWindow() {
		var currProduct = $(this).parent().parent().parent().data('productData');
		showEditWindow();
		$('#edit-product-container').find('#edit-product-button').on('click', editProduct);
		$('#edit-product-container').find('#edit-product-button').data('productId', currProduct.objectId);
	}

	function openDeleteWindow() {
		var currProduct = $(this).parent().parent().parent().data('productData');
		showDeleteWindow();
		$('#delete-product-container').find('#product-name').val(currProduct.name);
		$('#delete-product-container').find('#product-category').val(currProduct.category);
		$('#delete-product-container').find('#product-price').val(currProduct.price);
		$('#delete-product-container').find('#delete-product-button').on('click', deleteProduct);
		$('#delete-product-container').find('#delete-product-button').data('productId', currProduct.objectId);
	}

	function editProduct() {
		var productName = $('#item-name').val();
		var productCategory = $('#category').val();
		var productPrice = $('#price').val();
		var productId = $(this).data('productId');

		var data = {
			name: productName,
			category: productCategory,
			price: productPrice
		};

		service.editProduct(productId, data, editSuccessful, error);
	}

	function deleteProduct() {
		var productId = $(this).data('productId');
		service.deleteProduct(productId, deleteSuccessful, error);
	}

	function filterProducts() {
		var filterKey = $('#search-bar').val().toLowerCase();
		var minPrice = parseFloat($('#min-price').val());
		var maxPrice = parseFloat($('#max-price').val());
		var filterCategory = $('select#category').val();
		var $container = $('#products-container');

		$container.isotope({
			layoutMode: 'vertical'
		});
		$container.isotope({
			filter: function() {
				var name = $(this).find('.item-name').text();
				var price = parseFloat($(this).find('.price-box').text());
				var currCategory = $(this).find('.category-box').text();
				return name.indexOf(filterKey.toLowerCase()) !== -1 &&
					(minPrice <= price && maxPrice >= price) &&
					(filterCategory == currCategory || filterCategory == 'all');
			}
		})
	}

	function clearFilters() {
		var $container = $('#products-container');
		$container.isotope({
			layoutMode: 'vertical'
		});
		$container.isotope({
			filter: function() {
				return true;
			}
		})
	}

	function getCategories() {
		service.getProducts(drawCategories, error);
	}

	function drawCategories(data) {
		var categories = [];
		$(data.results).each(function(_, product) {
			if (categories.indexOf(product.category) < 0) {
				categories.push(product.category);
			}
		})

		$('select#category').children().remove();


		$('select#category').append($('<option>').attr('value', 'all').text('All'));
		$(categories).each(function(_, category) {
			$('select#category').append($('<option>').attr('value', category).text(category))
		});
	}

	function deleteSuccessful() {
		noty({
			text: 'Delete successful.',
			type: 'success',
			layout: 'topCenter',
			timeout: 2000
		});
		setTimeout(function() {
			showProducts();
		}, 1000);

		getCategories();
	}

	function editSuccessful() {
		noty({
			text: 'Edit successful.',
			type: 'success',
			layout: 'topCenter',
			timeout: 2000
		});
		setTimeout(function() {
			showProducts();
		}, 1000);

		getCategories();
	}

	function showProducts() {
		window.location.reload();
		document.location.hash = '#/products';
	}

	function showEditWindow() {
		$('#main').children().hide();
		$('#edit-product-container').show();
	}

	function showDeleteWindow() {
		$('#main').children().hide();
		$('#delete-product-container').show();
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
	//# sourceURL=products.js

}());
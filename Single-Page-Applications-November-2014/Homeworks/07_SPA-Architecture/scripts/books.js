(function () {
	'use strict';
	var counter = 1;

	$(function() {
		
		service.getAllBooks(drawBooks, error);

		$('#add-book').on('click', addBook);
		$('#edit-book').on('click', editBook);

	});


	function drawBooks(data){
		var tableHead = $('<thead>')
			.append(
				$('<tr>')
					.append($('<th>').text('#'))
					.append($('<th>').text('Author'))
					.append($('<th>').text('Title'))
					.append($('<th>').text('ISBN'))
					.append($('<th>').text('Edit/Remove'))
			);

		if (data.results.length > 0) {
			$('.books').append(tableHead);
			$('.books').append($('<tbody>'));

			$(data.results).each(function(index, book){
				var editButton = 
					$('<button id="edit-book-button" class="btn btn-xs btn-info" data-toggle="modal" data-target="#edit-book-modal">')
						.text('Edit')
						.on('click', function(){
							var bookId = $(this).parent().parent().attr('book-id');
							$('#inputEditBookId').text(bookId);
						});

				var removeButton = 
					$('<button class="btn btn-remove btn-xs btn-danger">')
						.text('Remove')
						.on('click', removeBook);

				$('.books tbody')
					.append(
						$('<tr>')
							.attr('book-Id', book.objectId)
							.append($('<td>').text(counter))
							.append($('<td>').text(book.author))
							.append($('<td>').text(book.title))
							.append($('<td>').text(book.isbn))
							.append($('<td>').append(editButton).append(removeButton))
					);

				counter++;
			});
		};
	}

	function addBook(){
		var editButton = 
			$('<button id="edit-book-button" class="btn btn-xs btn-info" data-toggle="modal" data-target="#edit-book-modal">')
				.text('Edit')
				.on('click', function(){
					var bookId = $(this).parent().parent().attr('book-id');
					$('#inputEditBookId').text(bookId);
				});

		var removeButton = 
			$('<button class="btn btn-remove btn-xs btn-danger">')
				.text('Remove')
				.on('click', removeBook);

		var bookTitle = $('#inputBookTitle').val();
		var bookAuthor = $('#inputBookAuthor').val();
		var bookISBN = $('#inputBookISBN').val();
		var data = {
			"author": bookAuthor,
			"title": bookTitle,
			"isbn": bookISBN
		};

		service.postBook(data, function(data){
			$('.books tbody')
				.append(
					$('<tr>')
						.attr('book-Id', data.objectId)
						.append($('<td>').text(counter))
						.append($('<td>').text(bookAuthor))
						.append($('<td>').text(bookTitle))
						.append($('<td>').text(bookISBN))
						.append($('<td>').append(editButton).append(removeButton))
				);
			counter++;
		}, error);
	}

	function editBook(){
		var bookTitle = $('#inputEditBookTitle').val();
		var bookAuthor = $('#inputEditBookAuthor').val();
		var bookIsbn = $('#inputEditBookISBN').val();
		var data = {
			"author": bookAuthor,
			"title": bookTitle,
			"isbn": bookIsbn
		};
		var bookId = $('#inputEditBookId').text();

		service.putBook(bookId, data, function(){
			var thisBookQuery = 'tr[book-id="'+ bookId +'"]'; 
			var book = $(thisBookQuery);
			book.find('td:nth-child(2)').text(bookAuthor);
			book.find('td:nth-child(3)').text(bookTitle);
			book.find('td:nth-child(4)').text(bookIsbn);
		}, error)
	}

	function removeBook(){
		var bookId = $(this).parent().parent().attr('book-Id');
		var _this = this;
		service.deleteBook(bookId, function(){
			$(_this).parent().parent().remove();
		}, error)
	}

	function error(){
		alert('Problemm :D');
	}

}());
(function () {
	'use strict';

	var BOOKMARK_BOX = 
		'<li class="bookmark-box">' +
			'<div>' +
				'<h2 class="bookmark-title">' +
					'{{bookmark-title}}' +
					'<button class="delete-bookmark">X</button>' +
				'</h2>' +
				'<a class="bookmark-url" href="{{bookmark-url}}">{{bookmark-url}}</a>' +
			'</div>' +
		'</li>';

	$(function() {
		listAllBookmarks();
		$('#add-bookmark-button').on('click', addBookmark);
	});

	function listAllBookmarks(){
		service.getBookmarks(drawBookmarks, error);
	}

	function drawBookmarks (data){
		$('#bookmarks').children().remove();
		$(data.results).each(function (_, bookmark){
			var $currBookmark = $(BOOKMARK_BOX
				.replace('{{bookmark-title}}', bookmark.title)
				.replace(/\{\{bookmark-url\}\}/g, bookmark.url));

			$currBookmark.data('bookmarkData', bookmark);
			$currBookmark.find('.delete-bookmark').on('click', deleteBookmark);
			$('#bookmarks').append($currBookmark);
		})
	}

	function deleteBookmark (){
		var currBookmark = $(this).parent().parent().parent().data('bookmarkData');
		service.deleteBookmark(currBookmark.objectId, deleteSuccessful, error);
	}

	function addBookmark (){
		var title = $('#title').val();
		var url = $('#url').val();
		//TODO: ADD bookmark with ACL
		//TODO: EDIT BOOKMARK

		service.addBookmark(title, url, bookmarkAddedSuccessful, error);
	}

	function bookmarkAddedSuccessful (argument){
		listAllBookmarks();
		$('#title').val('');
		$('#url').val('');
		noty({
                text: 'Bookmark added successful.',
                type: 'success',
                layout: 'topCenter',
                timeout: 4000}
        );
	}

	function deleteSuccessful (){
		listAllBookmarks();
		noty({
                text: 'Delete successful.',
                type: 'success',
                layout: 'topCenter',
                timeout: 4000}
        );
	}


	function error(msg) {
		noty({
                text: msg.responseJSON.error,
                type: 'error',
                layout: 'topCenter',
                timeout: 4000}
        );
	}

	// Debuging in chrome
	//# sourceURL=bookmark.js

}());
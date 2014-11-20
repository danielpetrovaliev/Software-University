(function(){
	var counter = 0;
	$(document).ready(function() {
		$('#toStart').on('click', appendToStart);
		$('#toEnd').on('click', appendToEnd);
	});


	function appendToStart(){
		counter++;

		var $newLi = $('<li>').text('Element: ' + counter);
		$('#elements').prepend($newLi);
	}

	function appendToEnd() {
		counter++;

		var $newLi = $('<li>').text('Element: ' + counter);
		$('#elements').append($newLi);
	}

})();
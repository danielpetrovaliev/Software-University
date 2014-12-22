app.controller('Home-Controller', ['$scope', 'VideosData',
	function($scope, VideosData) {

		$scope.videos = VideosData.videos;
		$scope.categories = (function() {

			var categories = [];
			var nonDublicatedCategories = [];

			$scope.videos.forEach(function(element, index) {

				categories.push(element.category);

			});

			categories.forEach(function(element, index){
				if (nonDublicatedCategories.indexOf(element) == -1 ) {
					nonDublicatedCategories.push(element);
				}
			});

			return nonDublicatedCategories;

		}());
	}
]);
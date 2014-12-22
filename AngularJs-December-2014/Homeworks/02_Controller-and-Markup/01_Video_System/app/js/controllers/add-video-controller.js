app.controller('Add-Video-Controller', ['$scope', 'VideosData', '$location', function($scope, VideosData, $location) {


		$scope.saveVideo = function(video) {
			video.subscribers = video.subscribers || 0;
			video.length = video.length || 'none';
			video.comments = video.comments || [];
			video.date = video.date || 'none';

			VideosData.addVideo(video);
			$location.path('/home');
		}

		$scope.cancelAdd = cancelAdd;

		function cancelAdd() {
			$location.path('/home');
		}



	}
]);
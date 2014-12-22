app.factory('VideosData', [function() {

		var videos = [{
			title: 'Aourse introduction',
			pictureUrl: 'http://stuchambers.files.wordpress.com/2012/08/training-course-group.jpg',
			length: '3:32',
			category: 'IT',
			subscribers: 5,
			date: formatDate(new Date(2014, 02, 01)),
			haveSubtitles: false,
			comments: [{
				username: 'Pesho Peshev',
				content: 'Congratulations Nakov',
				date: new Date(2014, 12, 15, 12, 30, 0),
				likes: 3,
				websiteUrl: 'http://pesho.com/'
			},
			{
				username: 'Pesho Peshev',
				content: 'Congratulations Nakov',
				date: new Date(2014, 12, 15, 12, 30, 0),
				likes: 3,
				websiteUrl: 'http://pesho.com/'
			},
			{
				username: 'Pesho Peshev',
				content: 'Congratulations Nakov',
				date: new Date(2014, 12, 15, 12, 30, 0),
				likes: 3,
				websiteUrl: 'http://pesho.com/'
			}]
		}, {
			title: 'Course introduction',
			pictureUrl: 'http://stuchambers.files.wordpress.com/2012/08/training-course-group.jpg',
			length: '3:32',
			category: 'IT',
			subscribers: 3,
			date: formatDate(new Date(2014, 02, 01)),
			haveSubtitles: true,
			comments: [{
				username: 'Pesho Peshev',
				content: 'Congratulations Nakov',
				date: new Date(2014, 12, 15, 12, 30, 0),
				likes: 3,
				websiteUrl: 'http://pesho.com/'
			}]
		},
		{
			title: 'Course introduction',
			pictureUrl: 'http://stuchambers.files.wordpress.com/2012/08/training-course-group.jpg',
			length: '3:32',
			category: 'IT',
			subscribers: 3,
			date: formatDate(new Date(2012, 12, 15)),
			haveSubtitles: true,
			comments: [{
				username: 'Pesho Peshev',
				content: 'Congratulations Nakov',
				date: new Date(2014, 12, 15, 12, 30, 0),
				likes: 3,
				websiteUrl: 'http://pesho.com/'
			}]
		},
		{
			title: 'Course introduction',
			pictureUrl: 'http://stuchambers.files.wordpress.com/2012/08/training-course-group.jpg',
			length: '3:32',
			category: 'IT',
			subscribers: 3,
			date: formatDate(new Date(2012, 12, 15)),
			haveSubtitles: true,
			comments: [{
				username: 'Pesho Peshev',
				content: 'Congratulations Nakov',
				date: new Date(2014, 12, 15, 12, 30, 0),
				likes: 3,
				websiteUrl: 'http://pesho.com/'
			}]
		}];

		function addVideo (video){
			videos.push(video);
		}

		function formatDate (date){
			var result = (date.getDay().toString().length == 1 ? ('0'+ date.getDay() ) : date.getDay()) + '/' + 
						(date.getMonth().toString().length == 1 ? ('0' + date.getMonth() ) : date.getMonth() ) + '/' + 
						date.getFullYear();

			return result;
		}


		return {
			videos: videos,
			addVideo: addVideo
		};


	}
]);
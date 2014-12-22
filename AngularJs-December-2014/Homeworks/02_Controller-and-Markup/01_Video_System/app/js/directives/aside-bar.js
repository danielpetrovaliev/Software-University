app.directive('asideBar', [function() {

		return {
			restrict: 'A',
			link: function(scope, iElement, iAttrs) {
				iElement.find('#sidebar').affix({
					offset: {
						top: 30,
					    bottom: function () {
				      		return (this.bottom = $('.footer').outerHeight(true))
					    }
					}
				});
			}
		};
	}
])
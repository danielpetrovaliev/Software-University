'use strict';

var app = angular
	.module('app', ['ngRoute'])
	.config(function($routeProvider, $locationProvider) {
		$routeProvider
            .when('/home', {
                templateUrl: 'js/templates/home.html'
            })
            .when('/add-video', {
            	templateUrl: 'js/templates/add-video.html',
            	controller: 'Add-Video-Controller'
            })
            .otherwise({redirectTo: '/home'});

            $locationProvider.html5Mode(true);
	})

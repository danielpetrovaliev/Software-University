app.filter('haveSubtitles', function() {
    return function(input) {
    	input = input.toString();

        switch (input) {
            case 'true': return "Yes"; break;
            case 'false': return "No"; break;
        }
    }
});
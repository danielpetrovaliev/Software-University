(function() {


    $(function () {
        var currentHash = window.location.hash;

        showContent();

        $(window).on('hashchange', function() {
            currentHash = window.location.hash;
            showContent();
        });

        function showContent() {
            switch (currentHash) {
                case '#home':
                    $('#page-content').load('../views/home.html');
                    break;
                case '#books':
                    $('#page-content').load('../views/books.html');
                    break;

                default :
                    $('#page-content').load('../views/home.html');
                    break;
            }
        }
    });


}());

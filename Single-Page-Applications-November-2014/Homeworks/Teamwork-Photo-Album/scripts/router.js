/**
 * Created by petrovaliev95 on 26-Nov-14.
 */
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
                    $('#page-content').load('views/home.html');
                    break;
                case '#login':
                    $('#page-content').load('views/login.html');
                    break;
                case '#singUp':
                    $('#page-content').load('views/register.html');
                    break;
                case '#about':
                    $('#page-content').load('views/about.html');
                    break;
                case '#albums':
                    $('#page-content').load('views/gallery.html');
                    break;

                default :
                    $('#page-content').load('views/home.html');
            }
        }
    });


}());

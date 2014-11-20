/**
 * Created by petrovaliev95 on 19-Nov-14.
 */
(function() {
    var index = 1;

    $(document).ready(function () {
        $('#button-left').on('click', previousSlide);
        $('#button-right').on('click', nextSlide);
        nextSlide();
    });


    function previousSlide(){
        switch (index) {
            case 1:
                index = 3;
                $('#images-container').children().hide();
                $('#image1').fadeIn(1000);
                break;
            case 2:
                index--;
                $('#images-container').children().hide();
                $('#image2').fadeIn(1000);
                break;
            case 3:
                index--;
                $('#images-container').children().hide();
                $('#image3').fadeIn(1000);
                break;
            default :
                $('#error-list').append($('<li>').html("Invalid Index"));
        }
    }

    function nextSlide(){
        switch (index) {
            case 1:
                index++;
                $('#images-container').children().hide();
                $('#image1').fadeIn(1000);
                break;
            case 2:
                index++;
                $('#images-container').children().hide();
                $('#image2').fadeIn(1000);
                break;
            case 3:
                index = 1;
                $('#images-container').children().hide();
                $('#image3').fadeIn(1000);
                break;
            default :
                $('#error-list').append($('<li>').html("Invalid Index"));
        }
    }
}());
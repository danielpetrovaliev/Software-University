/**
 * Created by petrovaliev95 on 18-Nov-14.
 */
(function() {

    $(document).ready(function () {
        $('#paintButton').on('click', changeBackground);
    });

    function changeBackground(){
        var $classValue = $('#class').val();
        var $colorValue = $('#color').val();

        $('.' + $classValue).css('background-color', $colorValue);
    }



}());
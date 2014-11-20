/**
 * Created by petrovaliev95 on 19-Nov-14.
 */
(function($){
    $.fn.messageBox = function () {
        var $this;
        $this = $(this);
        $this.append($('<h1>').addClass('message'));

        return this;
    };

    $.fn.success = function (text) {
        $('.message').html(text).addClass('success').hide().fadeIn(1000).fadeOut(2000);

        return this;
    };

    $.fn.error = function (text) {
        $('.message').html(text).addClass('error').hide().fadeIn(1000).fadeOut(2000);

        return this;
    };

}(jQuery));


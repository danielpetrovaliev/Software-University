/**
 * Created by petrovaliev95 on 20-Nov-14.
 */

(function() {
    var isHide = true;

    $(function () {
        $('.item').click(function () {
            $('.sub-items').toggle('fold', 1000);
        });

        $('.sub-item').click(function () {
            $('.in-sub-items').toggle('fold', 1000);
        });
    });

}());
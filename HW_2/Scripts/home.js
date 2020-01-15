function initMenu() {
    $('#menu ul').children('.current').parent().show();
    //$('#menu ul:first').show();
    $('#menu li a').click(
        function () {
            var checkElement = $(this).next();
            checkElement.stop().slideToggle();
        }
    );
}
$(document).ready(function () {
    initMenu();
});
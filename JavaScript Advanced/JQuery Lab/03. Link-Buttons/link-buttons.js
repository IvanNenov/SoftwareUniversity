function attachEvents() {
    let buttons = $('.button');
    buttons.removeClass('selected');
    buttons.on('click', function() {
        $('.selected').removeClass('selected');
        $(this).addClass('selected');
    });
}
function addSticker() {
    let title = $('.title');
    let text = $('.content');
    let stickerList = $('#sticker-list');

   if (title.val() && text.val()) {
       createSticker();
       reset();
   }

   function createSticker() {
    let li = $('<li>');
    li.addClass('note-content');

    let a = $('<a>');
    a.addClass('button').on('click', function() {
        li.remove();
    });
    a.text('x');
   
    let h2 = $('<h2>');
    h2.text(title.val());

    let p = $('<p>');
    p.text(text.val());

    li.append(a);
    li.append(h2);
    li.append($('<hr>'));
    li.append(p);

    stickerList.append(li);
   }

   function reset() {
       title.val('');
       text.val('');
   }
}
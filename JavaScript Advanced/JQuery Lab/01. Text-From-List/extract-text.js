function extractText() {
   let items = $('li').toArray().map(x => x.textContent);
   $('#result').text(items.join(', '));
}

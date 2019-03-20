function solution() {
	let toyType = $('#toyType');
	let toyPrice = $('#toyPrice');
	let toyDescription = $('#toyDescription');

	let section = $('#christmasGiftShop');

	if (toyType.val() !== '' && !isNaN(toyPrice.val()) && toyDescription.val() !== '') {

		let div = $('<div>');
		div.addClass('gift');

		let img = $('<img src="gift.png">');

		let h2 = $('<h2>');
		h2.text(toyType.val());

		let p = $('<p>');
		p.text(toyDescription.val());

		let button = $(`<button>Buy it for $${toyPrice.val()}</button>`).on('click',
			function () {
				div.remove();
			});

		div.append(img);
		div.append(h2);
		div.append(p);
		div.append(button);

		section.append(div);

		toyType.val('');
		toyDescription.val('');
		toyPrice.val('');
	}
}
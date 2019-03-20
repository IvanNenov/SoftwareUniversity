function acceptance() {
	let companyElement = $('#fields > td:nth-child(1) > input[type="text"]');
	let productElement = $('#fields > td:nth-child(2) > input[type="text"]');
	let quantityElement = $('#fields > td:nth-child(3) > input[type="text"]');
	let scrapeElement = $('#fields > td:nth-child(4) > input[type="text"]');
	let h1 = $('#warehouse > h1');

	let company = companyElement.val();
	let product = productElement.val();
	let quantity = quantityElement.val();
	let scrape = scrapeElement.val();

// 	- Company and product needs to be non-empty strings.
// - Quantity and scrape needs to be numbers.

	if (company !== '' && product !== '' && !isNaN(quantity) && !isNaN(scrape) && quantity > 0) {
		let peaces = quantity - scrape;
		if (peaces <= 0 ) {
			return;
		}
		let div = $('<div>');

		let p = $('<p>');
		p.text(`[${company}] ${product} - ${peaces} pieces`);
		
		let btn = $('<button>');
		btn.text('Out of stock');
		btn.on('click', function() {
			div.remove();
		});

		div.append(p);
		div.append(btn);

		h1.append(div);

		companyElement.val('');
		 productElement.val('');
		 quantityElement.val('');
		 scrapeElement.val('');
	}
}
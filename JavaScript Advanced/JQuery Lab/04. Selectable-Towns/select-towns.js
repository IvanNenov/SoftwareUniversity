function attachEvents() {
	let arrOfTowns = [];
	let towns = $('#items li').on('click', function() {
		let currentItem = $(this);

		if (currentItem.attr('data-selected') === 'true') {
			currentItem.attr('data-selected', 'false');
			currentItem.css('background', '');
			arrOfTowns.splice(arrOfTowns.indexOf(currentItem.text()),1);
			
		}
		else{
			currentItem.attr('data-selected', 'true');
			arrOfTowns.push(currentItem.text());
			currentItem.css('background', '#DDD');
		}
	
	});

	let result = $('#showTownsButton').on('click', function() {
		$('#selectedTowns').text(arrOfTowns.join(', '));
	});

}
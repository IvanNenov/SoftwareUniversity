function solve() {
	let createTitleElement = document.getElementById("createTitle");
	let titleElementValue = createTitleElement.value;

	let createContentElement = document.getElementById('createContent');
	let contentValue = createContentElement.value;

	if (titleElementValue && contentValue) {
		let titleElement = document.createElement('h3');
		titleElement.textContent = titleElementValue;

		let contentElement = document.createElement('p');
		contentElement.textContent = contentValue;

		let articleElement = document.createElement('article');
		articleElement.appendChild(titleElement);
		articleElement.appendChild(contentElement);

		let articlesElement = document.getElementById('articles');
		articlesElement.appendChild(articleElement);

		createTitleElement.value = '';
		createContentElement.value = '';
	}
}
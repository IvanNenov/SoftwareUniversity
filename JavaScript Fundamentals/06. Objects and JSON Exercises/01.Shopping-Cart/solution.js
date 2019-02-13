function solve() {
    let productsArr = [];

    let milkPrice = 0.0;
    let breadPrice = 0.00;
    let tomatoPrice = 0.00;

    let milkAddBtn = document.querySelector('div > button');
    let output = document.getElementsByTagName('textarea')[0];
    milkAddBtn.addEventListener('click', function () {
        milkPrice += 1.09;
        productsArr.push('Milk');
        output.textContent += `Added Milk for 1.09 to the cart.\n`;
    });

    let breadBtn = document.getElementsByTagName('button')[1];
    breadBtn.addEventListener('click', function () {
        breadPrice += 0.80;
        productsArr.push('Bread');
        output.textContent += `Added Bread for 0.80 to the cart.\n`;
    });

    let tomatoesBtn = document.getElementsByTagName('button')[2];
    tomatoesBtn.addEventListener('click', function () {
        tomatoPrice += 0.99;
        productsArr.push('Tomatoes');
        output.textContent += `Added Tomatoes for 0.99 to the cart.\n`;
    });

    let buyBtn = document.getElementsByTagName('button')[3];
    buyBtn.addEventListener('click', function () {
        let uniqueProducts = new Set();

        for (let product of productsArr) {
            uniqueProducts.add(product);
        }
        let uniqueProductsArr = [];

        for (let elements of uniqueProducts) {
            uniqueProductsArr.push(elements);
        }

        output.textContent += `You bought ${uniqueProductsArr.join(', ')} for ${(milkPrice + breadPrice + tomatoPrice).toFixed(2)}.\n`;
    });
}
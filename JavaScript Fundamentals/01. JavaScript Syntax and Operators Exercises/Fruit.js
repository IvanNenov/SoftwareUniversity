function fruit(typeofFruit, weight, pricePerKg) {
    
    let weightInKg = weight / 1000;
    let neededMoney = pricePerKg * weightInKg;

    console.log(`I need ${neededMoney.toFixed(2)} leva to buy ${weightInKg.toFixed(2)} kilograms ${typeofFruit}.`);
}

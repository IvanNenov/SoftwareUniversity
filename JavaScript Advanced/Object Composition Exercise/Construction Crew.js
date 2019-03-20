function workers(inputObj) {
    if (inputObj['handsShaking'] === false) {
        return inputObj;
    }

    let neededAlcoholAmount = parseFloat(inputObj['weight']) * parseFloat(inputObj['experience']) * 0.1;
    inputObj['bloodAlcoholLevel'] += neededAlcoholAmount;
    inputObj['handsShaking'] = false;
    return inputObj;
}

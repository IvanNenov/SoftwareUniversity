function sameNumbers(numbers) {

    numbers = Math.abs(numbers);
    let sum = 0;
    let areSame = false;
    let numToStr = numbers.toString();
    let size = numToStr.length;

    if (size === 1) {
        console.log(true);
        console.log(numbers);
        return;
    }

    for (let index = 0; index < size - 1; index++) {
        let element = +numToStr[index];
        let elementToCompare = +numToStr[index + 1];

        if (element === elementToCompare) {
            areSame = true;
        } else {
            areSame = false;
            console.log(false);

            for (let index = 0; index < size; index++) {
                sum += +numToStr[index];
            }

            console.log(sum);
            return;
        }
    }
    if (areSame) {

        for (let index = 0; index < size; index++) {
            sum += +numToStr[index];
        }

        console.log(true);
        console.log(sum);
    }
}
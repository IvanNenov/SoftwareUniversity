function solve(number1, number2) {

    let firstNumber = +number1;
    let secoundNumber = +number2;

    let sum = 0;
    for (let i = firstNumber; i <= secoundNumber; i++) {
        sum += i;
    }

    return sum;
}


function solve(number1, number2, operator) {

    let result = 0;

    switch (operator) {
        case "+":
        result = number1 + number2;
            break;

            case "-":
            result = number1 - number2;
            break;

            case "/":
            result = number1 / number2;
            break;

            case "*":
            result = number1 * number2;
            break;

            case "**":
            result = number1 ** number2;
            break;

            
            case "%":
            result = number1 % number2;
            break;

        default:
        console.log('Error');
        return;
            break;
    }

    console.log(result);

}


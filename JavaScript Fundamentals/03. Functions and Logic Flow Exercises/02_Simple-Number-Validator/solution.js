function validate() {
    let input = document.querySelector('input');
    let button = document.querySelector('button');
    let output = document.getElementById('response');
    let weightPosition = [2, 4, 8, 5, 10, 9, 7, 3, 6];

    button.addEventListener('click', function () {
        let number = input.value.toString();

        let validationCounter = 0;
        let sum = 0;

        for (i = 0; i < number.length; i++) {
            if (+number[i] < 0 || +number[i] > 9) {
                validationCounter++;
            }

            if (i + 1 == 10) {
                break;
            }
            else {
                sum += (+number[i] * +weightPosition[i]);
            }

            let remainder = sum % 11;
            if ((remainder % 10) === 0) {
                remainder = 0;
            }

            if ((+remainder === +number[9]) && (validationCounter === 0)) {
                output.textContent = "This number is Valid!";
            }
            else {
                output.textContent = "This number is NOT Valid!";
            }
        }
    }
    );
}
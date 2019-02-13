function greatestCD() {

    let result = document.getElementById('result');
    let firstN = document.getElementById("num1");
    let secondN = document.getElementById("num2");

    let firstNumber = firstN.value;
    let secondNumber = secondN.value;

    let solve = gcd(firstNumber,secondNumber);

    result.textContent = solve;

    firstN.value = "";
    secondN.value = "";

    function gcd (firstNumber,secondNumber) {
        let a = +firstNumber;
        let b = +secondNumber;

        if ( ! b) {
            return a;
        }
    
        return gcd(b, a % b);
    };
}



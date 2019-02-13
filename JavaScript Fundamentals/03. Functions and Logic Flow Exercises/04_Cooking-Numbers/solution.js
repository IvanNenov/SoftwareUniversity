function solve() {
    let input = document.querySelector('input');
    let chopButton = document.querySelector('button:nth-child(1)');
    let diceButton = document.querySelector('button:nth-child(2)');
    let spiceButton = document.querySelector('button:nth-child(3)');
    let bakeButton = document.querySelector('button:nth-child(4)');
    let filletButton = document.querySelector('button:nth-child(5)');
    let output = document.getElementById('output');

    chopButton.addEventListener('click', function() {
          numberIsZero();

          let number = input.value;
          let result = +number / 2;
          output.textContent = result;
          input.value = result;
    });

    diceButton.addEventListener('click', function() {
        numberIsZero();

        let number = input.value;
        let result = Math.sqrt(number);
        output.textContent = result;
        input.value = result;
    });

    spiceButton.addEventListener('click', function() {
        numberIsZero();

        let number = input.value;
        let result = +number + 1;
        output.textContent = result;
        input.value = result;
    });

    bakeButton.addEventListener('click', function(){
        numberIsZero();

        let number = input.value;
        let result = +number * 3;
        output.textContent = result;
        input.value = result;
    });

    filletButton.addEventListener('click',function() {
        numberIsZero();

        let number = input.value;
        let result = +number * 0.8;
        output.textContent = result;
        input.value = result;
    });

    function numberIsZero() {
        if (input.value == "") {
            input.value = 0;
        }
    }

}

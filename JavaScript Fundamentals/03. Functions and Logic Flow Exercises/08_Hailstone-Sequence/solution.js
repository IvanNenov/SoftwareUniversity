function getNext() {
    let result = document.getElementById('result');
    let number = document.getElementById('num').value;

    let sequence = [number];

    let tempNum = +number;

    while (tempNum !== 1) {
        if (tempNum % 2 === 0) {
            tempNum = +tempNum / 2;
        }

        else{
            tempNum = (3 * +tempNum) + 1 
        }
        sequence.push(tempNum);
    }

    result.textContent = sequence.join(" ") + " ";
}
function binarySearch() {

    let intArr = document.getElementById('arr');
    let num = document.getElementById('num');
    let result = document.getElementById('result');
    let numToFind = +num.value;
    let numbers = intArr.value.split(', ');
    let newIntArr = [];

    for (let i = 0; i < numbers.length; i++) {
        newIntArr[i] = (+numbers[i]);

    }

    let index = newIntArr.indexOf(numToFind);

    if (index === -1) {
        result.textContent = `${numToFind} is not in the array`;
    }

    else{
        result.textContent = `Found ${numToFind} at index ${index}`;
    }

    intArr.value = "";
    num.value = "";

}

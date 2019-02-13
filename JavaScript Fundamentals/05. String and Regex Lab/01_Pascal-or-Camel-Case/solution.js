function solve() {
    let firstString = document.getElementById('str1').value;
    let secoundString = document.getElementById('str2').value;
    let output = document.getElementById('result');

    let result = firstString
        .split(' ')
        .map(x => x[0].toUpperCase() + x.slice(1).toLowerCase())
        .join('');

    if (secoundString === 'Camel Case') {
        result = result[0].toLowerCase() + result.slice(1);
    }

    else if (secoundString !== 'Camel Case' && secoundString !== 'Pascal Case') {
        result = 'Error!';
    }

    output.textContent = result;
}
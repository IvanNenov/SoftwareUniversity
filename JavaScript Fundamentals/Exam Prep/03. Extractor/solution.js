function solve() {
    let output = document.getElementById('output');
    let btn = document.querySelector('button');

    btn.addEventListener('click', extract);

    function extract() {
        let input = document.getElementById('input').value;
    
        let pattern = /[0-9]+/g;

        let charsToTake = input.match(pattern)[0];
        let slicedStr = input.substr(charsToTake.length , +charsToTake);

        let delimiter = slicedStr[slicedStr.length - 1];
        let parts = slicedStr.split(delimiter).filter(x => x);

        parts[1] = parts[1].replace(new RegExp(`[${parts[0]}]`, 'g'), '').replace(/[#]/g, '');
        output.textContent = parts[1];
    }

}
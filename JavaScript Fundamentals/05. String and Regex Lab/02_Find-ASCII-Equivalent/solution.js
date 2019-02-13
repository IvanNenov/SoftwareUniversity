function solve() {
  let input = document.getElementById('str').value;
  let result = document.getElementById('result');

  let inputArr = input.split(' ');
  let output = '';

  inputArr.forEach(element => {
    if (Number(element)) {
      output += (String.fromCharCode(element));
    }

    else{
      let charToNum = [];

      for (let i = 0; i < element.length; i++) {
        charToNum.push(element[i].charCodeAt(0));
      }

      let p = document.createElement('p');
      p.textContent = charToNum.join(' ');
      result.appendChild(p);
    }
  });

  let paragraph = document.createElement('p');
  paragraph.textContent = output;
  result.appendChild(paragraph);
}
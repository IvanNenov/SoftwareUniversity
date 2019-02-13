function solve() {
  let input = document.getElementById('arr').value;
  let array = JSON.parse(input);

  let result = document.getElementById('result');

  for (let i = 0; i < array.length; i++) {
    let paragraph = document.createElement('p');
    paragraph.textContent = `${i} -> ${array[i] * array.length}`;
    result.appendChild(paragraph);
  }
}
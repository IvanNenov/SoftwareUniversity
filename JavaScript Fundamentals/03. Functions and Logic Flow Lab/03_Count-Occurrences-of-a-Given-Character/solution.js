function solve() {
  let fullText = document.getElementById('string').value;
  let character = document.getElementById('character').value;

  let counter = 0;
  let result = '';
  for (var i = 0; i < fullText.length; i++) {
    if(fullText[i] === character)
    counter++;
  }

  if (counter % 2 === 0) {
    result = `Count of ${character} is even.`
  }

  else{
    result = `Count of ${character} is odd.`;
  }

  let resultElement = document.getElementById('result');
  resultElement.textContent = result;
}
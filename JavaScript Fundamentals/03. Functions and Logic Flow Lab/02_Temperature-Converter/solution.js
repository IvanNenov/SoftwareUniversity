function solve() {
  let num = Number(document.getElementById('num1').value);
  let type = document.getElementById('type').value;

  let result = document.getElementById('result');
  let convertedTemperature = 0;
  let correctType = false;
  
  if (type.toUpperCase() === "CELSIUS" ) {
    convertedTemperature = (((num * 9) / 5) + 32);
    correctType = true;
  }

  else if (type.toUpperCase() === "FAHRENHEIT") {
    convertedTemperature = (((num - 32) * 5) / 9);
    correctType = true
  }

  else {
    correctType = false;
    result.textContent = "Error!";
  }

  if (correctType) {
    result.textContent = Math.round(convertedTemperature);
  }
}
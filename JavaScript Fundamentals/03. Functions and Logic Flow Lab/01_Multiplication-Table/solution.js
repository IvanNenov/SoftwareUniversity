function solve() {
  let num = document.getElementById("num1").value;
  let multiplier = document.getElementById("num2").value;
  let divResult = document.getElementById("result");

  if (+num > +multiplier) {
    divResult.textContent = "Try with other numbers.";
  }


  for (var i = +num; i <= +multiplier; i++) {
    let paragraph = document.createElement("p");
    paragraph.textContent = `${i} * ${+multiplier} = ${i * +multiplier}`;
    divResult.appendChild(paragraph);
  }


}
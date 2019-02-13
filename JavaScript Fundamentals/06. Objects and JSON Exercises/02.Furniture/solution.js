function solve() {
  let list = [];
  let totalPrice = 0;
  let df = [];
  document.getElementsByTagName('button')[0].addEventListener('click', function () {
    let futnitureList = JSON.parse(document.getElementsByTagName('textarea')[0].value);
    for (let furniture of futnitureList) {
      let div = document.createElement('div');
      div.setAttribute('class', 'furniture');
      let name = document.createElement('p');
      name.innerHTML = `Name: ${furniture.name}`;
      let img = document.createElement('img');
      img.setAttribute('src', furniture.img);
      let price = document.createElement('p');
      price.innerHTML = `Price: ${furniture.price}`;

      let decorationFactor = document.createElement('p');
      decorationFactor.innerHTML = `Decoration factor: ${furniture.decFactor}`;
      let checkBox = document.createElement('input');
      checkBox.setAttribute('type', 'checkbox');
      div.appendChild(name);
      div.appendChild(img);
      div.appendChild(price);
      div.appendChild(decorationFactor);
      div.appendChild(checkBox);  

      document.getElementById('furniture-list').appendChild(div);
    }
    
  });

  document.getElementsByTagName('button')[1].addEventListener('click', () => {
    let arr =  Array.from(document.getElementById('furniture-list').children);

    for (let furniture of arr) {
      let isCheckbox = furniture.getElementsByTagName('input')[0].checked;

      if (isCheckbox) {
        let name = furniture.getElementsByTagName('p')[0].innerHTML.split(': ')[1];
        list.push(name);
        let price = +furniture.getElementsByTagName('p')[1].innerHTML.split(': ')[1];
        totalPrice += price;
        let factor = +furniture.getElementsByTagName('p')[2].innerHTML.split(': ')[1];
        df.push(factor);
      }

    }
    let textArea = document.getElementsByTagName('textarea')[1];
    textArea.value += `Bought furniture: ${list.join(', ')}\n`;
    textArea.value += `Total price: ${totalPrice.toFixed(2)}\n`;
    let average = df.reduce((a,b) => a + b) /  df.length;
    textArea.value += `Average decoration factor: ${average}`;
  });

}
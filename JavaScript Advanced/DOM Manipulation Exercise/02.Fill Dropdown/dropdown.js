function addItem() {
    let newItemTextElement = document.getElementById('newItemText');
    let newItemValueElement = document.getElementById('newItemValue');
    let menu = document.getElementById('menu');

    let text = newItemTextElement.value;
    let value = newItemValueElement.value;

    let option = document.createElement('option');
    option.textContent = text;
    option.value = value;

    menu.appendChild(option);
    newItemTextElement.value = '';
    newItemValueElement.value = '';
}
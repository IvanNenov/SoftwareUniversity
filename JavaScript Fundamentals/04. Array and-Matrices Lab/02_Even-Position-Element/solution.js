function solve() {
  let input = document.querySelector('input').value;
  let result = document.getElementById('result');
  result.textContent = input.split(', ').filter(x => x % 2 !== 0).join(' x ');
}
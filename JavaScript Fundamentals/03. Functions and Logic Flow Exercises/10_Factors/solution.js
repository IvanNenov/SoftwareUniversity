function solve() {
   let num = document.getElementById('num');
   let numValue = +num.value;

   let factors = number => Array
      .from(Array(number + 1), (_, i) => i)
      .filter(i => number % i === 0)

   let result = factors(numValue);

   let spanResult = document.getElementById('result');
   spanResult.textContent = result.join(" ");

}
function solve(arr) {

    console.log(`Sum = ${arr.reduce((acc, b) => acc + b, 0)}`);
    console.log(`Min = ${arr.reduce((acc, b) => Math.min(acc , b))}`);
    console.log(`Max = ${arr.reduce((acc, b) => Math.max(acc, b))}`);
    console.log(`Product = ${arr.reduce((acc, b) => acc * b, 1)}`);
    console.log(`Join = ${arr.join('')}`);
  
}

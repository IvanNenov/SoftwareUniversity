function solve(a, b, c) {

    let firstLenght = a.length;
    let secoundLenght = b.length;
    let thirdLenght = c.length;

    let sumOfLenghts = firstLenght + secoundLenght + thirdLenght;
    let average = Math.floor(sumOfLenghts / 3);

    console.log(sumOfLenghts);
    console.log(average);
}

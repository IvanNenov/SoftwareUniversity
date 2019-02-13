function solve() {
  let input = document.getElementById('str').value;
  let northOrEastPattern = /north|east/gi;

  let resultArrNorthAndEst = input.match(northOrEastPattern);
  
  let messagePattern = /(<>).+(<>)/gi;
  let resultMsg = input.match(messagePattern);

  for (let i = 0; i < resultMsg.length; i++) {
    console.log(resultMsg[i]);
    
  }
}
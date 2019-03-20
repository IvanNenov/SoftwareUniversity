function solve(arr, sortingCriteria) {

    class Ticket{
        constructor(destination, price, status){
            this.destination =destination;
            this.price = price;
            this.status = status;
        }
    }   
    let arrTickets = [];

    for (let i = 0; i < arr.length; i++) {
        let currentRowInfo = arr[i].split('|');
        let destination = currentRowInfo[0];
        let price = +currentRowInfo[1];
        let status = currentRowInfo[2];

        arrTickets.push(new Ticket(destination, price, status));
    }
    let newarr = [];
    newarr = arrTickets.sort((a,b) => {
        if (a[sortingCriteria] > b[sortingCriteria]) {
            return 1;
        }

        else  if (b[sortingCriteria] < a[sortingCriteria]) {
            return -1;
        }
        else {
            return 0;
        }
    });

    return newarr;
}

    
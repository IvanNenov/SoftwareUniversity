function fibonacci() {
    return (function () {
        let firstNum = 0;
        let secoundNum = 1;

        return function () {
            let result = secoundNum;
            let sum = firstNum + secoundNum;
            firstNum = secoundNum;
            secoundNum = sum;

            return result;
        }
    })();
}


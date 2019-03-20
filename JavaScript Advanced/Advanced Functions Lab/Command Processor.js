function solve(arr) {
    let result = '';
    for (let i = 0; i < arr.length; i++) {
        let commands = arr[i].split(' ');
        if (commands[0] === 'append') {
            let str = commands[1];
            result += str;
        } else if (commands[0] === 'removeStart') {
            let n = +commands[1];
            result = result.substr(n, result.length - 1);

        } else if (commands[0] === 'removeEnd') {
            let n = +commands[1];
             result = result.split("").reverse().join("").substring(n, result.length).split("").reverse().join("");
            
        } else if (commands[0] === 'print') {
            console.log(result);
        }
    }
}

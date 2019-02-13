function solve(arr) {
    let resultArr = arr.reduce((acc, command, index) => {
        if (command === "add") {
            acc.push(index + 1);
        }

        else if (command === "remove") {
            acc.pop();
        }

        return acc;
    }, []);

    if (resultArr.length > 0) {
        return resultArr.join('\n');
    }
    else{
        return 'Empty';
    }
}
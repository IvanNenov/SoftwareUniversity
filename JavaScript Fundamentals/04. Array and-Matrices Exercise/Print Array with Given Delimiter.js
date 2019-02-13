function PrintEveryNthElementFromAnArray(arr) {
    let step = +arr.pop();
    let result = arr.reduce((acc, el, index) => {
        if (index % step === 0) {
            acc.push(el);
        }

        return acc;
    }, []);

    return result.join('\n');
}
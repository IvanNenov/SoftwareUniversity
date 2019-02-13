function CalorieObject(params) {
    let obj = {};

    for (let i = 0; i < params.length - 1; i++) {
        if (i % 2 == 0) {
            let name = params[i];
            obj[name] = +params[i + 1];
        }
    }

    console.log(obj);
}
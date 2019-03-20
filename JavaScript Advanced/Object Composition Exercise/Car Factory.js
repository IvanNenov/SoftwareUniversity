function cars(inputObj) {
    let obj = {};
    obj.model = inputObj.model;

    if (inputObj.power <= 90) {
        obj.engine = {
            power: 90,
            volume: 1800
        };
    } else if (inputObj.power > 90 && inputObj.power <= 120) {
        obj.engine = {

            power: 120,
            volume: 2400
        };
    } else if (inputObj.power >= 200) {
        obj.engine = {
            power: 200,
            volume: 3500
        };
    }

    if (inputObj.carriage === 'hatchback') {
        obj.carriage = {
            type: 'hatchback',
            color: inputObj.color
        };
    } else {
        obj.carriage = {
            type: 'coupe',
            color: inputObj.color
        };
    }

    let wheelDiameter = +inputObj.wheelsize;

    if (wheelDiameter % 2 == 0) {
        wheelDiameter--;
    }

    let wheels = [wheelDiameter, wheelDiameter, wheelDiameter, wheelDiameter];
    obj.wheels = wheels;

    return obj;
}
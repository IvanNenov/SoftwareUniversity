function solve(input){
    let sum = 0;

    add.toString = function(){
        return sum;
    }

    function add(){
        sum += +(arguments[0]);
        return add;
    }

    return add(input);
}
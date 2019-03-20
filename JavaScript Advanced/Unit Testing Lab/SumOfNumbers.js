let assert = require('chai').assert;

function sum(arr) {
    let sum = 0;
    for (num of arr)
        sum += Number(num);
    return sum;
}

describe('sum', function() {
    it ("should return correct result", function() {
        assert.equal(sum([1, 2, 3]), 6)
    });

    it ("should return zero if array is empty", function() {
        assert.equal(sum([]), 0);
    });

    it ("should return only one number", function() {
        assert.equal(sum([10]), 10);
    });
});

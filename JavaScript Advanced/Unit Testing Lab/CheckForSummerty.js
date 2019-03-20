let assert = require('chai').assert;

function isSymmetric(arr) {
    if (!Array.isArray(arr))
        return false; // Non-arrays are non-symmetric
    let reversed = arr.slice(0).reverse(); // Clone and reverse
    let equal = (JSON.stringify(arr) == JSON.stringify(reversed));
    return equal;
}


describe('isSymmetric', function() {
    it ('should return false if input is not an array', function() {
        assert.equal(isSymmetric({}), false);
    });

    it ('should return true if array is symmetric', function() {
        assert.equal(isSymmetric([1, 2, 3, 3, 2, 1]), true);
    });

    it ('should return false if array is not symmetric', function() {
        assert.equal(isSymmetric([1, 8, 3, 6, 2, 1]), false);
    });

    it ('should return false if array has only one value', function() {
        assert.equal(isSymmetric([1]), true);
    });

    it ('should return true if array is empty', function() {
        assert.equal(isSymmetric([]), true);
    });
});
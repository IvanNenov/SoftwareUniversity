let assert = require('chai').assert;

function isOddOrEven(string) {
    if (typeof(string) !== 'string') {
        return undefined;
    }
    if (string.length % 2 === 0) {
        return "even";
    }

    return "odd";
}

describe('isOddOrEven', function() {
    it('should return undefined if parameter is not a string', function() {
        assert.equal(isOddOrEven({name : 'pepi'}), undefined);
    });

    it('should return odd if string lenght is odd', function() {
        assert.equal(isOddOrEven('pesho'), 'odd');
    });

    it('should return even if string lenght is even', function() {
        assert.equal(isOddOrEven('ivan'), 'even');
    })
});
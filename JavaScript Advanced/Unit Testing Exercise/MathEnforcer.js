let assert = require('chai').assert;

let mathEnforcer = {
    addFive: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num + 5;
    },
    subtractTen: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num - 10;
    },
    sum: function (num1, num2) {
        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        }
        return num1 + num2;
    }
};
describe('mathEnforcer', function() {

    describe('addFive', function() {
        it('should return undefined if parameter is NAN', function() {
            assert.equal(mathEnforcer.addFive('xa'), undefined);
            assert.equal(mathEnforcer.addFive(''), undefined);

        });

        it('should return five', function() {
            assert.equal(mathEnforcer.addFive(5), 10);
            assert.equal(mathEnforcer.addFive(-5), 0);
        });
    });

    describe('subtractTen', function() {
        it('should return undefined if parameter is NAN', function() {
            assert.equal(mathEnforcer.subtractTen('xa'), undefined);
            assert.equal(mathEnforcer.subtractTen(''), undefined);
        });

        it('should return 10 if parameter is 20', function() {
            assert.equal(mathEnforcer.subtractTen(20), 10);
            assert.equal(mathEnforcer.subtractTen(-10), -20);

        });
    });

    describe('sum', function() {
        it('should return undefined if any of parameters is not a number', function() {
            assert.equal(mathEnforcer.sum('xa', 'xa'), undefined);
            assert.equal(mathEnforcer.sum(1, 'xa'), undefined);
            assert.equal(mathEnforcer.sum(1, ''), undefined);
            assert.equal(mathEnforcer.sum('xa', 1), undefined);
            assert.equal(mathEnforcer.sum('', 1), undefined);

        });

        it('should return sum numbers', function() {
            assert.equal(mathEnforcer.sum(2,3), 5);
            assert.equal(mathEnforcer.sum(0, 0), 0);
            assert.equal(mathEnforcer.sum(-20, 10), -10);
        });
    });
});

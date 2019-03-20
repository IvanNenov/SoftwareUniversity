let assert = require('chai').assert;

class Calculator {
    constructor() {
        this.expenses = [];
    }

    add(data) {
        this.expenses.push(data);
    }

    divideNums() {
        let divide;
        for (let i = 0; i < this.expenses.length; i++) {
            if (typeof (this.expenses[i]) === 'number') {
                if (i === 0 || divide===undefined) {
                    divide = this.expenses[i];
                } else {
                    if (this.expenses[i] === 0) {
                        return 'Cannot divide by zero';
                    }
                    divide /= this.expenses[i];
                }
            }
        }
        if (divide !== undefined) {
            this.expenses = [divide];
            return divide;
        } else {
           throw new Error('There are no numbers in the array!')
        }
    }

    toString() {
        if (this.expenses.length > 0)
            return this.expenses.join(" -> ");
        else return 'empty array';
    }

    orderBy() {
        if (this.expenses.length > 0) {
            let isNumber = true;
            for (let data of this.expenses) {
                if (typeof data !== 'number')
                    isNumber = false;
            }
            if (isNumber) {
                return this.expenses.sort((a, b) => a - b).join(', ');
            }
            else {
                return this.expenses.sort().join(', ');
            }
        }
        else return 'empty';
    }
}

describe("calculator", function() {
    it("should has a property expenses", function() {
        let calculator = new Calculator();
        let expected = [].length;
        let actual = calculator.expenses.length;
        assert.equal(actual, expected);
    });
    
    it("should has method add(string)", function() {
        let calculator = new Calculator();
        calculator.add('Pesho');
        assert.equal(calculator.expenses.toString(), [ "Pesho" ]);
    });

    it("should has method add(number)", function() {
        let calculator = new Calculator();
        calculator.add(123);
        assert.equal(calculator.expenses.toString(), [ "123" ]);
    });

    it("should has method add(number) and (string)", function() {
        let calculator = new Calculator();
        calculator.add(123);
        calculator.add('pesho');
        assert.equal(calculator.expenses.length,2);
    });

    it("should divide the numbers in the array", function() {
        let calculator = new Calculator();
        calculator.add(10);
        calculator.add('pesho');
        calculator.add(2);
        assert.equal(calculator.divideNums().toString(), '5');
    });

    it("should throw an exception if there are no numbers in the array", function() {
        let calculator = new Calculator();
        calculator.add('xa');
        calculator.add('pesho');
        calculator.add('xaxa');
        assert.throws(() => calculator.divideNums(), 'There are no numbers in the array!');
    });

    it("should throw an exception if there are no input", function() {
        let calculator = new Calculator();
        
        assert.throws(() => calculator.divideNums(), 'There are no numbers in the array!');
    });

    it("division with float", function() {
        let calculator = new Calculator();
        calculator.add(10.5);
        calculator.add(2);
        assert.closeTo(calculator.divideNums(), 5.25, 0.01);
    });

    it("division with zero", function() {
        let calculator = new Calculator();
        calculator.add(10.5);
        calculator.add(0);
        assert.equal(calculator.divideNums(), 'Cannot divide by zero');
    });

    it("should return empty array", function() {
        let calculator = new Calculator();
        assert.equal(calculator.toString(), 'empty array');
    });

    it("should return array to string", function() {
        let calculator = new Calculator();
        calculator.add('xa');
        calculator.add('pesho');
        calculator.add(true);
        calculator.add(1);

        assert.equal(calculator.toString(), 'xa -> pesho -> true -> 1');
    });

    it("order by nums", function() {
        let calculator = new Calculator();
        calculator.add(1);
        calculator.add(5);
        calculator.add(2);
        calculator.add(3);
        calculator.add(4);

        assert.equal(calculator.orderBy(), '1, 2, 3, 4, 5');
    });

    it("order mixed", function() {
        let calculator = new Calculator();
        calculator.add(1);
        calculator.add(3);
        calculator.add('xa');
        calculator.add('go');
        calculator.add('na');

        assert.equal(calculator.orderBy(), '1, 3, go, na, xa');
    });


});



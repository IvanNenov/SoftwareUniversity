let assert = require('chai').assert;

class Warehouse {

    get capacity() {
        return this._capacity;
    }

    set capacity(givenSpace) {

        if (typeof givenSpace === 'number' && givenSpace > 0) {
            return this._capacity = givenSpace;
        } else {
            throw `Invalid given warehouse space`;
        }
    }

    constructor(capacity) {
        this.capacity = capacity;
        this.availableProducts = {
            'Food': {},
            'Drink': {}
        };
    }

    addProduct(type, product, quantity) {

        let addedQuantity = ((this.capacity - this.occupiedCapacity()) - quantity);
        let output;

        if (addedQuantity >= 0) {

            if (this.availableProducts[type].hasOwnProperty(product) === false) {
                this.availableProducts[type][product] = 0;
            }

            this.availableProducts[type][product] += quantity;
            output = this.availableProducts[type];

        } else {
            throw `There is not enough space or the warehouse is already full`;
        }

        return output;
    }

    orderProducts(type) {

        let output;
        let sortedKeys = Object.keys(this.availableProducts[type])
            .sort((a, b) => this.availableProducts[type][b] - this.availableProducts[type][a]);

        let newObj = {};

        for (let product of sortedKeys) {

            if (newObj.hasOwnProperty(product) === false) {
                newObj[product] = 0;
            }

            newObj[product] += this.availableProducts[type][product];
        }

        this.availableProducts[type] = newObj;
        output = this.availableProducts[type];

        return output;
    }

    occupiedCapacity() {

        let output = 0;
        let productsCount = Object.keys(this.availableProducts['Food']).length +
            Object.keys(this.availableProducts['Drink']).length;

        if (productsCount > 0) {

            let quantityInStock = 0;

            for (let type of Object.keys(this.availableProducts)) {

                for (let product of Object.keys(this.availableProducts[type])) {

                    quantityInStock += this.availableProducts[type][product];
                }
            }

            output = quantityInStock;
        }

        return output;
    }

    revision() {

        let output = "";

        if (this.occupiedCapacity() > 0) {

            for (let type of Object.keys(this.availableProducts)) {
                output += `Product type - [${type}]\n`;
                for (let product of Object.keys(this.availableProducts[type])) {
                    output += `- ${product} ${this.availableProducts[type][product]}\n`;
                }
            }
        } else {
            output = 'The warehouse is empty';
        }

        return output.trim();
    }

    scrapeAProduct(product, quantity) {

        let type = Object.keys(this.availableProducts).find(t => Object.keys(this.availableProducts[t]).includes(product));
        let output;

        if (type !== undefined) {

            if (quantity <= this.availableProducts[type][product]) {
                this.availableProducts[type][product] -= quantity;
            } else {
                this.availableProducts[type][product] = 0;
            }

            output = this.availableProducts[type];

        } else {
            throw `${product} do not exists`;
        }

        return output;
    }
}
let warehouse = new Warehouse(10);
warehouse.addProduct('Food', 'Banana', 3);
warehouse.addProduct('Food', 'Apple', 2);
warehouse.addProduct('Drink', 'Cola', 3);
warehouse.addProduct('Drink', 'Fresh', 2);
console.log(warehouse.scrapeAProduct('Banana'));


describe("Warehouse", function () {
    it("should be throw a string msg if value is 0", function () {
        assert.throw(() => new Warehouse(0), 'Invalid given warehouse space');
    });

    it("should be throw a string msg if value is negative num", function () {
        assert.throw(() => new Warehouse(-10), 'Invalid given warehouse space');
    });

    it("should add the given product", function () {
        let warehouse = new Warehouse(15);

        warehouse.addProduct('Food', 'Banana', 3);
        assert.equal(warehouse.occupiedCapacity(), 3);
    });

    it("should sum the quantity if the given product is already added", function () {
        let warehouse = new Warehouse(15);

        warehouse.addProduct('Food', 'Banana', 3);
        warehouse.addProduct('Food', 'Banana', 3);
        warehouse.addProduct('Food', 'Banana', 3);
        warehouse.addProduct('Food', 'Banana', 3);

        assert.equal(warehouse.occupiedCapacity(), 12);
    });

    it("should throw There is not enough space or the warehouse is already full", function () {
        let warehouse = new Warehouse(2);

        assert.throw(() => warehouse.addProduct('Food', 'Banana', 3), 'There is not enough space or the warehouse is already full');
    });

    it("should order by descending by quantity", function () {
        let warehouse = new Warehouse(10);
        warehouse.addProduct('Food', 'Banana', 3);
        warehouse.addProduct('Food', 'Apple', 2);
        warehouse.addProduct('Food', 'Cherry', 3);
        warehouse.addProduct('Food', 'Tomato', 1);

        assert.equal(warehouse.orderProducts('Food').toString(), {
            Banana: 3,
            Cherry: 3,
            Apple: 2,
            Tomato: 1
        });

    });

    it("should order by descending by quantity", function () {
        let warehouse = new Warehouse(10);
        warehouse.addProduct('Food', 'Banana', 3);
        warehouse.addProduct('Food', 'Apple', 2);
        warehouse.addProduct('Food', 'Cherry', 3);
        warehouse.addProduct('Food', 'Tomato', 1);

        assert.equal(warehouse.orderProducts('Food').toString(), {
            Banana: 3,
            Cherry: 3,
            Apple: 2,
            Tomato: 1
        });

    });

    it("should order by descending by quantity", function () {
        let warehouse = new Warehouse(10);
        warehouse.addProduct('Food', 'Banana', 3);
        warehouse.addProduct('Food', 'Apple', 2);
        warehouse.addProduct('Food', 'Cherry', 3);
        warehouse.addProduct('Food', 'Tomato', 1);

        assert.equal(warehouse.occupiedCapacity(), 9);
    });

    it("should return warehouse is empty", function () {
        let warehouse = new Warehouse(10);

        assert.equal(warehouse.revision(), 'The warehouse is empty');
    });

    it("should returns a string in which we print all products of each type", function () {
        let warehouse = new Warehouse(12);
        warehouse.addProduct('Food', 'Banana', 3);
        warehouse.addProduct('Food', 'Apple', 2);
        warehouse.addProduct('Drink', 'Cola', 3);
        warehouse.addProduct('Drink', 'Fresh', 2);
        assert.equal(warehouse.revision().toString(),
            'Product type - [Food]\n- Banana 3\n- Apple 2\nProduct type - [Drink]\n- Cola 3\n- Fresh 2');
    });

    it("should return a string with summed quantity", function () {
        let warehouse = new Warehouse(12);
        warehouse.addProduct('Food', 'Banana', 3);
        warehouse.addProduct('Food', 'Banana', 2);
        warehouse.addProduct('Drink', 'Cola', 3);
        warehouse.addProduct('Drink', 'Cola', 2);
        assert.equal(warehouse.revision().toString(),
            'Product type - [Food]\n- Banana 5\nProduct type - [Drink]\n- Cola 5');
    });

    it("should reduce quantity", function () {
        let warehouse = new Warehouse(12);
        warehouse.addProduct('Food', 'Banana', 3);
        warehouse.addProduct('Food', 'Apple', 2);
        assert.equal(warehouse.scrapeAProduct('Banana').toString(),
            {Banana: 0, Apple: 2});
    });

    it("should return products not exist", function () {
        let warehouse = new Warehouse(12);
        warehouse.addProduct('Food', 'Banana', 3);
        warehouse.addProduct('Food', 'Apple', 2);
        assert.throw( () => warehouse.scrapeAProduct('xa'),
            'xa do not exist');
    });

    //{product} do not exists'
});
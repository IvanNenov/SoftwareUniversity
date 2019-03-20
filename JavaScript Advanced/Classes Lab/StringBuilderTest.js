let assert = require('chai').assert;

class StringBuilder {
    constructor(string) {
        if (string !== undefined) {
            StringBuilder._vrfyParam(string);
            this._stringArray = Array.from(string);
        } else {
            this._stringArray = [];
        }
    }

    append(string) {
        StringBuilder._vrfyParam(string);
        for (let i = 0; i < string.length; i++) {
            this._stringArray.push(string[i]);
        }
    }

    prepend(string) {
        StringBuilder._vrfyParam(string);
        for (let i = string.length - 1; i >= 0; i--) {
            this._stringArray.unshift(string[i]);
        }
    }

    insertAt(string, startIndex) {
        StringBuilder._vrfyParam(string);
        this._stringArray.splice(startIndex, 0, ...string);
    }

    remove(startIndex, length) {
        this._stringArray.splice(startIndex, length);
    }

    static _vrfyParam(param) {
        if (typeof param !== 'string') throw new TypeError('Argument must be string');
    }

    toString() {
        return this._stringArray.join('');
    }
}

describe('StringBuilder', function () {
            it('can be instantiated with a passed string parameter', function () {
                assert.isOk(new StringBuilder('pesho'));
            });

            it('can be instantiated without a passed parameter', function () {
                assert.isOk(new StringBuilder());
            });

            it('should be add to the end of the string', function () {
                let sb = new StringBuilder();
                sb.append('hello ');
                sb.append('from');
                assert.equal(sb.toString(), 'hello from');
            });

            it('should be add to the beggining of the string', function () {
                let sb = new StringBuilder();
                sb.append('from ');
                sb.append('me');
                sb.prepend('HI, ')
                assert.equal(sb.toString(), 'HI, from me');
            });

            it('should be insert at given index', function () {
                let sb = new StringBuilder();
                sb.append('XAXA');
                sb.insertAt('-', 2);
                assert.equal(sb.toString(), 'XA-XA');

            });

            it('should remove at given index', function () {
                let sb = new StringBuilder();
                sb.append('XA_XA');
                sb.remove(2, 1);
                assert.equal(sb.toString(), 'XAXA');

            });

            it('should throw an exception append', function () {
                let sb = new StringBuilder();
                assert.Throw(() => sb.append(undefined), Error);

            });
            it('should throw an exception insert at', function () {
                let sb = new StringBuilder();
                assert.Throw(() => sb.insertAt(undefined, undefined), Error);

            });

            it('should throw an exception prepend', function () {
                let sb = new StringBuilder();
                assert.Throw(() => sb.prepend(undefined), Error);

            });
});
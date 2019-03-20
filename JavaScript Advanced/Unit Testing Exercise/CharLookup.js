let assert = require('chai').assert;

function lookupChar(string, index) {
    if (typeof(string) !== 'string' || !Number.isInteger(index)) {
        return undefined;
    }
    if (string.length <= index || index < 0) {
        return "Incorrect index";
    }

    return string.charAt(index);
}
describe('lookupChar', function() {
    it('should return undefined if first parameter is not a string or secound is not an integer', function() {
        assert.equal(lookupChar(1,1), undefined);
        assert.equal(lookupChar('pesho','xa'), undefined);
        assert.equal(lookupChar('da', []), undefined);
        assert.equal(lookupChar(1), undefined);
        assert.equal(lookupChar('pesho', 1.23), undefined);
    });

    it('should return Incorrect index if value is negative number, bigger than str lenght or equal to str lenght', function() {
        assert.equal(lookupChar('pesho', -123), 'Incorrect index');
        assert.equal(lookupChar('pesho', 123), 'Incorrect index');
        assert.equal(lookupChar('pesho', 5), 'Incorrect index');
     });    

     it('should return correct char at given index', function() {
        assert.equal(lookupChar('pesho', 1), 'e');
        assert.equal(lookupChar('da', 0) , 'd');
        assert.equal(lookupChar('stamat', 3), 'm');
        assert.equal(lookupChar('le le', 2), ' ');
     });

});
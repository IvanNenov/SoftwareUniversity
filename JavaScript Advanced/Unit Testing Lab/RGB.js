let assert = require('chai').assert;

function rgbToHexColor(red, green, blue) {
    if (!Number.isInteger(red) || (red < 0) || (red > 255))
        return undefined; // Red value is invalid
    if (!Number.isInteger(green) || (green < 0) || (green > 255))
        return undefined; // Green value is invalid
    if (!Number.isInteger(blue) || (blue < 0) || (blue > 255))
        return undefined; // Blue value is invalid
    return "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);
}

describe('rgbToHex', function() {
    it("should return undefined if color < 0 || color > 255",() => {
        let belowZero = -1;
        let over255 = 256;

        let invalidType = "25";

        let greenBelowZeroResult = rgbToHexColor(1, belowZero, 1);
        let greenOver255Result = rgbToHexColor(1, over255, 1);
        let greenInvalidTypeResult = rgbToHexColor(1, invalidType, 1);
        
        let blueBelowZeroResult = rgbToHexColor(1, 1, belowZero);
        let blueOver255Result = rgbToHexColor(1, 1, over255);
        let blueInvalidTypeResult = rgbToHexColor(1, 1, invalidType);
        
        let redBelowZeroResult = rgbToHexColor(belowZero, 1, 1);
        let redOver255Result = rgbToHexColor(over255, 1, 1);
        let redInvalidTypeResult = rgbToHexColor(invalidType, 1, 1);

        assert.equal(greenBelowZeroResult, undefined);
        assert.equal(greenOver255Result, undefined);
        assert.equal(greenInvalidTypeResult, undefined);
        
        assert.equal(blueBelowZeroResult, undefined);
        assert.equal(blueOver255Result,undefined);
        assert.equal(blueInvalidTypeResult, undefined);
        
        assert.equal(redBelowZeroResult,undefined);
        assert.equal(redOver255Result, undefined);
        assert.equal(redInvalidTypeResult, undefined);
    });

    it("should return correct result for 24, 24, 24", () => {
        let red = 24;
        let green = 24;
        let blue = 24;

        let expectedOutput = "#" + 
        ("0" + red.toString(16).toUpperCase()).slice(-2) + 
        ("0" + green.toString(16).toUpperCase()).slice(-2) + 
        ("0" + blue.toString(16).toUpperCase()).slice(-2);

        let result = rgbToHexColor(red, green, blue);

        assert.equal(result, expectedOutput);
    });

    it("should return undefined result for 24, '24', 24", () => {
        let red = 24;
        let green = '24';
        let blue = 24;

        let expectedOutput = "#" + 
        ("0" + red.toString(16).toUpperCase()).slice(-2) + 
        ("0" + green.toString(16).toUpperCase()).slice(-2) + 
        ("0" + blue.toString(16).toUpperCase()).slice(-2);

        let result = rgbToHexColor(red, green, blue);

        assert.isUndefined(result);
    });
})
pragma solidity >= 0.4.22 < 0.6.0;

contract MathOperation {

    function add(uint a, uint b) 
    public
    pure
    returns (uint) {
        return a + b;
    }

    function subtract(uint a, uint b)
    public
    pure
    returns (uint){
        return a - b;
    }

    function multiply (uint a, uint b)
    public 
    pure
    returns(uint){
        return a * b;
    }

    function divide(uint a, uint b)
    public 
    pure
    returns(uint){
        return a / b;
    }

    function power(uint a, uint b)
    public
    pure
    returns(uint){
        return a**b;
    }

    function remainder(uint a, uint b)
    public
    pure
    returns (uint){
        return a % b;
    }

}
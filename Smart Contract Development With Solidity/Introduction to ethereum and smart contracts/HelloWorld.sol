pragma solidity >= 0.4.22 < 0.6.0;

contract Greeter {
    function greet () 
    public
    pure
    returns (string memory){
        return "Hello world";
    }
}
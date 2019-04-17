pragma solidity >= 0.4.22 < 0.6.0;

contract Counter {
    
    uint public counter = 0;

    function count() public {
    
        counter ++;
    }
    
}
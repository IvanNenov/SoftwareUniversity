pragma solidity >= 0.4.22 < 0.6.0;

contract RandomNumber{
    
    function Random() public payable returns (uint randomNumber){ 
        return (uint)((msg.value + now) % 10);
                
    }
}

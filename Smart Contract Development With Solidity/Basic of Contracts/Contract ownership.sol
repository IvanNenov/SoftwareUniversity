pragma solidity >=0.4.22 <0.6.0;
 
contract Ownership {
    event FallbackEvent(address sender, uint sendValue);
    event OwnerChange(address oldOwner, address newOwner);
   
    address public owner;
    address public prospectOwner;
    uint256 public ownershipChangeTimestamp;
   
    constructor () public {
        owner = msg.sender;
    }
   
    modifier isOwner {
        require(msg.sender == owner);
        _;
    }
   
    modifier timeRestrain {
        require((ownershipChangeTimestamp + 30 seconds) < now);
        _;
    }
   
    function transferOwnership(address newOwner) public isOwner {
        emit OwnerChange(owner, newOwner);
        prospectOwner = newOwner;
        ownershipChangeTimestamp = now;
    }
   
    function acceptOwnership() public timeRestrain {
        require(msg.sender == prospectOwner);
        owner = prospectOwner;
    }
   
    function() external payable {
        emit FallbackEvent(msg.sender, msg.value);
    }
}
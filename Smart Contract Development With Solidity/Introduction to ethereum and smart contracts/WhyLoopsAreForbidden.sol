pragma solidity >= 0.4.22 < 0.6.0;

contract Loop {
   
    function iterativeFactoriel(int number)
    public
    pure
    returns(int num){
        int result = number;
        for (int i = 1; i < number; i++) {
            result *= i;
        }

        return result;
    }
}
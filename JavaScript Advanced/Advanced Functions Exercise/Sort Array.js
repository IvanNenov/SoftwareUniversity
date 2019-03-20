function solve(arr, sortMethod) {
    
    let ascendingComparator = function(a ,b) {
        return a - b;
    }
    
    let descComparator = function(a ,b){
        return b - a;
    }
    
    let sortedStategies = {
        'asc' : ascendingComparator,
        'desc' : descComparator
    }
    
    
    return arr.sort(sortedStategies[sortMethod]);

}

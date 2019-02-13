function theGratestCommonDivisor(a , b) {
    
    let r=a % b;

    while (b != 0){
        r=a % b;
        a = b;
        b = r;
    }

    console.log(a);
}

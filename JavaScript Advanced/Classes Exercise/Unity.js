class Rat{
     
    constructor(name){
        this.name = name;
        this.arr = [];
        
    }

    getRats(){
        return this.arr;
    }

    toString(){
        let result = "";
        result += this.name + "\n";
        Array.from(this.arr).forEach((rat) => {
            result += "##" + rat.name.toString() + "\n";
        });
        
        result = result.trim();

        return result;
    }

    unite(rat){
        if (!rat) {

        }

        else if(rat.constructor.name !== "Rat"){

        }
        else{
            this.arr.push(rat);
        }
    }

}


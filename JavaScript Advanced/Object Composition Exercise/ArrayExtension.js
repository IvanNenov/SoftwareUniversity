(function () {

        Array.prototype.last = function(){
            return this[this.length - 1];
        };

        Array.prototype.skip = function(n) {
            let newArr = [];

            for (let i = 0; i < this.length; i++) {
                if (this[i] === n) {
                    continue;
                }

                else{
                    newArr.push(this[i]);
                }
            }

            return newArr;
        };

        Array.prototype.take = function(n) {
           let newArr = [];
           for (let i = 0; i < n; i++) {
               newArr.push(this[i]);
               
           }  
           return newArr;
        };

        Array.prototype.sum = function() {
           return this.reduce((a,b) => a+b);
        };

        Array.prototype.average = function() {
           let sum = this.reduce((a,b) => a+b);
           let avg = sum / this.length;
           return avg;
        };
})()

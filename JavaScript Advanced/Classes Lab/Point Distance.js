class Point{
    constructor(x ,y){
        this._x = x;
        this._y = y;
    }

    static distance(p1, p2){
        return Math.sqrt(Math.pow((p2._x - p1._x),2) + Math.pow((p2._y - p1._y),2));
    }
}


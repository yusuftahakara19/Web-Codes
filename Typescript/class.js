var Taxi = /** @class */ (function () {
    function Taxi() {
    }
    Taxi.prototype.travelTo = function (point) {
        console.log("taksi ".concat(point.x, " konumundan ").concat(point.y, " konumuna gidiyor."));
    };
    return Taxi;
}());
var Bus = /** @class */ (function () {
    function Bus() {
    }
    Bus.prototype.travelTo = function (point) {
        console.log("bus ".concat(point.x, " konumundan ").concat(point.y, " konumuna gidiyor."));
    };
    return Bus;
}());

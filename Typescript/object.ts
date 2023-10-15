interface Point {
  x: number;
  y: number;
}

interface Passenger {
  name: string;
  phone: string;
}

interface Vehicle {
  currentLocation: Point;
  travelTo(point: Point): void;
}

class Taxi implements Vehicle {
  //.. taxi class özelindeki özellikler
  currentLocation: Point;
  travelTo(point: Point): void {
    console.log(`taksi ${point.x} konumundan ${point.y} konumuna gidiyor.`);
  }
}

class Bus implements Vehicle {
  //..bus class özelindeki özellikler
  currentLocation: Point;
  travelTo(point: Point): void {
    console.log(`bus ${point.x} konumundan ${point.y} konumuna gidiyor.`);
  }
}

let taxi_1: Taxi = new Taxi();
taxi_1.travelTo({ x: 1, y: 2 });
taxi_1.currentLocation = { x: 10, y: 12 };

let taxi_2 = new Taxi();

console.log(taxi_1.currentLocation.x);
console.log(taxi_1.currentLocation.y);

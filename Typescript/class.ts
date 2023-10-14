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

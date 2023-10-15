interface Point {
  x: number;
  y: number;
}

interface Passenger {
  name: string;
  phone: string;
}

interface Vehicle {
  travelTo(point: Point): void;
}

class Taxi implements Vehicle {
  constructor(private location: Point, private color?: string) {}
  travelTo(point: Point): void {
    console.log(
      `taksi  ${this.location.x}  ${this.location.y} konumundan ${point.x} ${point.y} konumuna gidiyor.`
    );
  }
}

let taxi_1 = new Taxi({ x: 10, y: 15 }, `Red`);

taxi_1.travelTo({ x: 20, y: 50 });

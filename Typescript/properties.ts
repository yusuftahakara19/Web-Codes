import { Taxi } from "./Taxi";

export interface Point {
  x: number;
  y: number;
}

interface Passenger {
  name: string;
  phone: string;
}

export interface Vehicle {
  travelTo(point: Point): void;
}

let taxi_1 = new Taxi({ x: 10, y: 15 }, `Red`);

taxi_1.setLocation({ x: 19, y: 19 });
taxi_1.travelTo({ x: 20, y: 50 });

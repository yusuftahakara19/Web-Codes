import { Vehicle } from "./properties";
import { Point } from "./properties";
export class Taxi implements Vehicle {
  constructor(private _location: Point, private _color?: string) {}
  travelTo(point: Point): void {
    console.log(
      `taksi  ${this._location.x}  ${this._location.y} konumundan ${point.x} ${point.y} konumuna gidiyor.`
    );
  }

  getLocation() {
    return this._location;
  }

  setLocation(value: Point) {
    if (value.x < 0 || value.y < 0) {
      throw new Error("Koordinat bilgisi negatif olamaz");
    }
    this._location = value;
  }
}

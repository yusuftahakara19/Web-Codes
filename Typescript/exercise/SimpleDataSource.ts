import { Product } from "./Product";

export class SimpleDataSource {
  private products: Array<Product>;
  constructor() {
    this.products = new Array<Product>(
      new Product(1, "Samsung S6", "Telefon", 1000),
      new Product(2, "Samsung S7", "Telefon", 2000),
      new Product(3, "Samsung S8", "Telefon", 3000),
      new Product(4, "Samsung S9", "Telefon", 4000)
    );
  }

  getProducts(): Array<Product> {
    return this.products;
  }
}

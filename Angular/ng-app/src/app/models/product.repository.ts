import { Product } from './product';

export class ProductRepository {
  private products: Product[] = [
    {
      id: 1,
      name: 'iphone15',
      price: 20000,
      imageUrl: '1.png',
      description: 'iyi telefon',
      isActive: true,
    },
    {
      id: 2,
      name: 'iphone16',
      price: 21000,
      imageUrl: '1.png',
      description: 'iyi telefon',
      isActive: true,
    },
    {
      id: 3,
      name: 'iphone17',
      price: 22000,
      imageUrl: '1.png',
      description: 'iyi telefon',
      isActive: true,
    },
  ];

  getProducts() {
    return this.products.filter((p) => p.isActive);
  }

  getProductById(id: number): Product | undefined {
    return this.products.find((p) => p.id == id);
  }
}

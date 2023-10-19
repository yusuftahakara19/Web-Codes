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
      categoryId: 1,
    },
    {
      id: 2,
      name: 'iphone16',
      price: 21000,
      imageUrl: '2.png',
      description: 'iyi telefon',
      isActive: true,
      categoryId: 1,
    },
    {
      id: 3,
      name: 'iphone17',
      price: 22000,
      imageUrl: '3.png',
      description: 'iyi telefon',
      isActive: true,
      categoryId: 2,
    },
    {
      id: 4,
      name: 'iphone18',
      price: 30000,
      imageUrl: '1.png',
      description: 'iyi telefon',
      isActive: true,
      categoryId: 2,
    },
    {
      id: 5,
      name: 'iphone19',
      price: 41000,
      imageUrl: '2.png',
      description: 'iyi telefon',
      isActive: true,
      categoryId: 2,
    },
    {
      id: 6,
      name: 'iphone20',
      price: 52000,
      imageUrl: '3.png',
      description: 'iyi telefon',
      isActive: true,
      categoryId: 3,
    },
  ];

  getProducts() {
    return this.products.filter((p) => p.isActive);
  }

  getProductById(id: number): Product | undefined {
    return this.products.find((p) => p.id == id);
  }
  getProductByCategoryId(id: number) {
    return this.products.filter((p) => p.categoryId == id);
  }
}

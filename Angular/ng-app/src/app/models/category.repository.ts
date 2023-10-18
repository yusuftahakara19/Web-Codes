import { Category } from './category';

export class CategoryRepository {
  private categories: Category[] = [
    { id: 1, name: 'Telefon' },
    { id: 1, name: 'Bilgisayar' },
    { id: 1, name: 'Televizyon' },
  ];

  getCategories(): Category[] {
    return this.categories;
  }

  getCategoryById(id: number) {
    return this.categories.find((x) => x.id == id);
  }
}

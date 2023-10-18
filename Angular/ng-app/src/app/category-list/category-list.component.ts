import { Component, OnInit } from '@angular/core';
import { CategoryRepository } from '../models/category.repository';
import { Category } from '../models/category';

@Component({
  selector: 'category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css'],
})
export class CategoryListComponent implements OnInit {
  categories: Category[];
  categoriy_repository: CategoryRepository;
  selectedCategory: Category | null;
  constructor() {
    this.categoriy_repository = new CategoryRepository();
    this.categories = this.categoriy_repository.getCategories();
  }

  ngOnInit(): void {}

  selectCategory(category: Category) {
    if (this.selectedCategory == category) {
      this.selectedCategory = null;
    } else {
      this.selectedCategory = category;
    }
  }
}

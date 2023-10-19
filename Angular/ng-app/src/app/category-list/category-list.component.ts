import { Component, OnInit } from '@angular/core';
import { CategoryRepository } from '../models/category.repository';
import { Category } from '../models/category';
import { Router } from '@angular/router';

@Component({
  selector: 'category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css'],
})
export class CategoryListComponent implements OnInit {
  categories: Category[];
  categoriy_repository: CategoryRepository;
  selectedCategory: Category | null;
  constructor(private router: Router) {
    this.categoriy_repository = new CategoryRepository();
    this.categories = this.categoriy_repository.getCategories();
  }

  ngOnInit(): void {}

  displayAll = false;
  selectCategory(category?: Category) {
    if (category) {
      if (this.selectedCategory == category) {
        this.selectedCategory = null;
        this.displayAll = true;
        this.router.navigate(['/products']); // Navigate to the '/products' route
      } else {
        this.selectedCategory = category;
        this.displayAll = false;
      }
    } else {
      this.displayAll = true;
      this.selectedCategory = null;
    }
  }
}

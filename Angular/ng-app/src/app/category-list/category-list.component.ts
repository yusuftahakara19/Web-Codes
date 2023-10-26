import { Component, OnInit } from '@angular/core';
import { CategoryRepository } from '../models/category.repository';
import { Category } from '../models/category';
import { Router } from '@angular/router';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css'],
  providers: [CategoryService],
})
export class CategoryListComponent implements OnInit {
  categories: Category[];

  selectedCategory: Category | null;
  constructor(
    private router: Router,
    private categoryService: CategoryService
  ) {}

  ngOnInit(): void {
    this.categoryService.getCategory().subscribe((data) => {
      this.categories = data;
    });
  }

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

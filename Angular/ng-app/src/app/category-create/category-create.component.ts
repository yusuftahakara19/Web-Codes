import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../services/category.service';
import { Category } from '../models/category';
import { Router } from '@angular/router';

@Component({
  selector: 'app-category-create',
  templateUrl: './category-create.component.html',
  styleUrls: ['./category-create.component.css'],
  providers: [CategoryService],
})
export class CategoryCreateComponent implements OnInit {
  constructor(
    private router: Router,
    private categoryService: CategoryService
  ) {}

  ngOnInit(): void {}

  saveCategory(name: any) {
    const category = {
      id: -1,
      name: name.value,
    };

    this.categoryService
      .createCategory(category)
      .subscribe((result) => this.router.navigate(['/products']));
  }
}

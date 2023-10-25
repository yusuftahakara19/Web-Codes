import { Component, OnInit } from '@angular/core';
import { ProductService } from '../services/product.service';
import { Router } from '@angular/router';
import { CategoryService } from '../services/category.service';
import { Category } from '../models/category';

@Component({
  selector: 'app-product-create',
  templateUrl: './product-create.component.html',
  styleUrls: ['./product-create.component.css'],
  providers: [ProductService, CategoryService],
})
export class ProductCreateComponent implements OnInit {
  categories: Category[] = [];

  constructor(
    private productService: ProductService,
    private router: Router,
    private categoryService: CategoryService
  ) {}

  ngOnInit(): void {
    this.categoryService.getCategory().subscribe((data) => {
      this.categories = data;
    });
  }

  saveProduct(
    name: any,
    price: any,
    imageUrl: any,
    description: any,
    isActive: any,
    categoryId: any
  ) {
    const product = {
      id: -1,
      name: name.value,
      price: price.value,
      imageUrl: imageUrl.value,
      description: description.value,
      isActive: isActive.checked,
      categoryId: categoryId.value,
    };

    this.productService.createProduct(product).subscribe((result) => {
      this.router.navigate(['/products']);
    });
  }
}

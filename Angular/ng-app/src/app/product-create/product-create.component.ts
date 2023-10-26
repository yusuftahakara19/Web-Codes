import { Component, OnInit } from '@angular/core';
import { ProductService } from '../services/product.service';
import { Router } from '@angular/router';
import { CategoryService } from '../services/category.service';
import { Category } from '../models/category';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-product-create',
  templateUrl: './product-create.component.html',
  styleUrls: ['./product-create.component.css'],
  providers: [ProductService, CategoryService],
})
export class ProductCreateComponent implements OnInit {
  categories: Category[] = [];
  error: string = '';
  model: any = {
    name: '-',
    price: '0',
    categoryId: '0',
    isActive: false,
  };

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

  saveProduct(form: NgForm) {
    console.log(this.model);

    const extensions = ['jpeg', 'jpg', 'png'];
    const extension = this.model.imageUrl.split('.').pop();

    if (extensions.indexOf(extension) == -1) {
      this.error = `Resim uzantısı ${extensions} olmalı`;
      return;
    }
    if (this.model.categoryId == '0') {
      this.error = `Kategori seçiniz`;
      return;
    }
    const product = {
      id: -1,
      name: this.model.name,
      price: this.model.price,
      imageUrl: this.model.imageUrl,
      description: this.model.description,
      isActive: this.model.isActive,
      categoryId: this.model.categoryId,
    };

    if (form.valid) {
      this.productService.createProduct(product).subscribe((result) => {
        this.router.navigate(['/products']);
      });
    } else {
      this.error = 'formu kontrol edin.';
    }
  }
}

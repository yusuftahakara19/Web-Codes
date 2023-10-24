import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { ProductRepository } from '../models/product.repository';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css'],
  providers: [ProductService],
})
export class ProductListComponent implements OnInit {
  products: Product[] = [];

  constructor(
    private route: ActivatedRoute, // active bir route gerekli bu yüzden bunu buraya yazıyoruz.
    private productService: ProductService
  ) {}

  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      // subscribe yazmamızın sebebi asenkron bir işlem ve bu sebeple onun hazır olmasını bekleyeceğiz
      this.productService
        .getProducts(params['categoryId'])
        .subscribe((data) => {
          this.products = data;
        });
    });
  }
}

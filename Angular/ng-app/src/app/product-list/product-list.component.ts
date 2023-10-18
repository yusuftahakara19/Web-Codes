import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { ProductRepository } from '../models/product.repository';

@Component({
  selector: 'product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css'],
})
export class ProductListComponent implements OnInit {
  products: Product[];
  selectedProduct: Product | null;
  productRepository: ProductRepository;

  constructor() {
    this.productRepository = new ProductRepository();
    this.products = this.productRepository.getProducts();
  }

  ngOnInit(): void {}

  selectProduct(product: Product) {
    this.selectedProduct = product;
  }
  unSelectProduct() {
    this.selectedProduct = null;
  }
}

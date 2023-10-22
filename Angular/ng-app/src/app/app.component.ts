import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ProductService } from './services/product.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [ProductService],
})
export class AppComponent {
  title = 'Home Page';

  constructor(
    private http: HttpClient,
    private productService: ProductService
  ) {}

  createProduct() {
    const product = {
      id: 4,
      name: 'iphone18',
      price: 50000,
      imageUrl: '1.png',
      description: 'iyi telefon',
      isActive: true,
      categoryId: 1,
    };

    this.productService
      .createProduct(product)
      .subscribe((result) => console.log(result));
  }
}

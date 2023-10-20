import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'Home Page';

  constructor(private http: HttpClient) {}

  createProduct() {
    const product = {
      id: 3,
      name: 'iphone17',
      price: 40000,
      imageUrl: '3.png',
      description: 'iyi telefon',
      isActive: true,
      categoryId: 1,
    };

    this.http
      .post(
        `https://ng-shoppapp-a4857-default-rtdb.firebaseio.com/product.json`,
        product
      )
      .subscribe((result) => console.log(result));
  }
}

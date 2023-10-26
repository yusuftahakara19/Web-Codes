import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from '../models/product';
import { Observable, delay, map } from 'rxjs';

//local service
@Injectable()
export class ProductService {
  private url = `https://ng-shoppapp-a4857-default-rtdb.firebaseio.com/`;

  //constructor'da bir http nesnesini inject edeceğiz.
  constructor(private http: HttpClient) {}

  getProducts(categoryId: number): Observable<Product[]> {
    return this.http.get<Product[]>(this.url + 'product.json').pipe(
      map((data) => {
        const products: Product[] = [];

        for (let key in data) {
          if (categoryId) {
            if (categoryId == data[key].categoryId) {
              products.push({ ...data[key], id: key });
            }
          } else {
            products.push({ ...data[key], id: key });
          }
        }

        return products;
      }),
      delay(500)
    );
  }

  getProductById(id: string): Observable<Product> {
    return this.http
      .get<Product>(this.url + 'product/' + id + '.json')
      .pipe(delay(500));
  }

  createProduct(product: Product): Observable<Product> {
    return this.http.post<Product>(this.url + 'product.json', product);
  }
}

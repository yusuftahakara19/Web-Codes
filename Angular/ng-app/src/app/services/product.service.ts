import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from '../models/product';
import { Observable } from 'rxjs';

//local service
@Injectable()
export class ProductService {
  private url = `https://ng-shoppapp-a4857-default-rtdb.firebaseio.com/product.json`;

  //constructor'da bir http nesnesini inject edeceğiz.
  constructor(private http: HttpClient) {}

  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.url);
  }

  createProduct(product: Product): Observable<Product> {
    return this.http.post<Product>(this.url, product);
  }
}

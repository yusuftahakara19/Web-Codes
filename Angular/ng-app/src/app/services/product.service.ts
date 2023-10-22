import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from '../models/product';
import { Observable } from 'rxjs';

//local service
@Injectable()
export class ProductService {
  private url = `https://ng-shoppapp-a4857-default-rtdb.firebaseio.com/`;

  //constructor'da bir http nesnesini inject edeceğiz.
  constructor(private http: HttpClient) {}

  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.url + 'product.json');
  }

  getProductById(id: string): Observable<Product> {
    return this.http.get<Product>(this.url + 'product/' + id + '.json');
  }

  createProduct(product: Product): Observable<Product> {
    return this.http.post<Product>(this.url + 'product.json', product);
  }
}

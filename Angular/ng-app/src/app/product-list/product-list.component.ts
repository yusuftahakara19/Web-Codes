import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { ProductRepository } from '../models/product.repository';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css'],
})
export class ProductListComponent implements OnInit {
  products: Product[] = [];
  productRepository: ProductRepository;

  constructor(private route: ActivatedRoute, private http: HttpClient) {
    // active bir route gerekli bu yüzden bunu buraya yazıyoruz.
    this.productRepository = new ProductRepository();
  }

  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      // subscribe yazmamızın sebebi asenkron bir işlem ve bu sebeple onun hazır olmasını bekleyeceğiz
      if (params['categoryId']) {
        this.products = this.productRepository.getProductByCategoryId(
          params['categoryId']
        );
      } else {
        this.http
          .get<Product[]>( // dönece olan nesnenin tipini belirtebiliyorsun.
            `https://ng-shoppapp-a4857-default-rtdb.firebaseio.com/product.json`
          )
          .subscribe((result) => {
            for (let key in result) {
              this.products.push({ ...result[key], id: key });
            }
          });
      }
    });
  }
}

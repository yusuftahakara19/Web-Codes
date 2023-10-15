import { Product } from "./Product";
import { ProductService } from "./ProductService";

let _productService = new ProductService();

let result;
result = _productService.getById(3);

let p = new Product();
p.id = 2;
p.name = "Iphone4";
p.category = "Telefon";
p.price = 4000;

_productService.saveProduct(p);
result = _productService.getProducts();

console.log(result);

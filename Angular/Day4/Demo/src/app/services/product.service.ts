
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  url: string = "http://localhost:3005/products";
    constructor(private http : HttpClient) { }

    getallProducts()
    {
      return this.http.get(this.url);
    }

    getProductById(productId :any)
    {
      return this.http.get(`${this.url}/${productId}`);
    }
    addProduct(product: any) {
      return this.http.post(this.url, product);
    }
    editProduct(productId :any,product: any) {
      return this.http.put(`${this.url}/${productId}`, product);
    }
    deleteProduct(productId: any) {
      return this.http.delete(`${this.url}/${productId}`);
    } 

}

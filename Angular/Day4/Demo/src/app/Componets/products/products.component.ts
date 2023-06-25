import { Component, OnInit } from '@angular/core';

import { ProductService } from 'src/app/services/product.service';


@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  products: any = [];
  // products: IProduct[] = []

  constructor(private productService: ProductService) {
    // this.products = productList;
  }
  ngOnInit(): void {
    this.productService.getallProducts().subscribe((response) => { this.products = response });
  }
  deleteProduct(productId: any) {
    this.productService.deleteProduct(productId).subscribe(() => {
      this.products = this.products.filter(
        (product: any) => product.id != productId
      );
    });
  }
}

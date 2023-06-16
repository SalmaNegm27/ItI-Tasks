import { Component } from '@angular/core';
import { productList } from 'src/app/Models/Product';
import { IProduct } from 'src/app/Models/IProduct';


@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent {

  products: IProduct[] = []
  constructor() {
    this.products = productList;
  }
}

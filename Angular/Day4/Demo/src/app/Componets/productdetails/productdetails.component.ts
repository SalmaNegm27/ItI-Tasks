import { ProductService } from 'src/app/services/product.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-productdetails',
  templateUrl: './productdetails.component.html',
  styleUrls: ['./productdetails.component.css']
})
export class ProductdetailsComponent  implements OnInit{
  productId : any;
  product : any ;
  constructor(
    private router : Router ,
    private activatedRoute: ActivatedRoute,
    private productService: ProductService
  ){}
 ngOnInit() : void 
 {
  this.productId = this.activatedRoute.snapshot.paramMap.get('id');
  this.productService.getProductById(this.productId).subscribe({
    next: (response) => {
      this.product = response;
    },
    error: (error) => {
      console.log(error);
    },
  });
}
  


backToHome() {
  this.router.navigate(['/products']);
}
}



import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-addproduct',
  templateUrl: './addproduct.component.html',
  styleUrls: ['./addproduct.component.css']
})
export class AddproductComponent implements OnInit {
  productId:any;
  product:any;
 
  constructor(private router : Router, private productService: ProductService ,private activatedRoute: ActivatedRoute)
  {
  }
  ngOnInit(): void {
   this.productId = this.activatedRoute.snapshot.paramMap.get('id');
   console.log(this.productId)
   if (this.productId != 0)
   {
    this.productService.getProductById(this.productId).subscribe({
      next : (response)=>{
        this.product = response;
        this.getProductName.setValue(this.product.productName);
        this.getProductPrice.setValue(this.product.price);
          this.getQuantity.setValue(this.product.quantity);
          this.getImaage.setValue(this.product.imgUrl);
      }
    });
   }
  }
productForm = new FormGroup(
  {
    productName : new FormControl('',[Validators.required,Validators.minLength(3)]),
    price : new FormControl('',[Validators.required,Validators.max(10000)]),
    quantity : new FormControl('',[Validators.required,Validators.max(100),Validators.min(10)]) ,
    imgUrl : new FormControl('',[Validators.required]) 
  }

);
get getProductName() {
  return this.productForm.controls['productName'];
}
get getProductPrice() {
  return this.productForm.controls['price'];
}
get getQuantity() {
  return this.productForm.controls['quantity'];
}
get getImaage() {
  return this.productForm.controls['imgUrl'];
}
formOperation(e:any)
{
  
  e.preventDefault()
  if (this.productForm.status == 'VALID')
  {
    if (this.productId == 0) {
      this.productService
        .addProduct(this.productForm.value)
        .subscribe(() => {});
        console.log(this.productId)
    } else {
      this.productService
        .editProduct(this.productId, this.productForm.value)
        .subscribe();
    }
    this.router.navigate(['./products']);
  }
}


}

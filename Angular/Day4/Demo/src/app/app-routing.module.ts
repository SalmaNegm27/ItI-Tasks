import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Componets/home/home.component';
import { LoginComponent } from './Componets/login/login.component';
import { ErrorComponent } from './error/error.component';
import { ProductsComponent } from './Componets/products/products.component';
import { ProductdetailsComponent } from './Componets/productdetails/productdetails.component';
import { AddproductComponent } from './Componets/addproduct/addproduct.component';
const routes: Routes = [
  {path:'home',component : HomeComponent},
  {path:'login', component : LoginComponent},
 

  {path : 'products',component: ProductsComponent},
  {path : 'products/:id', component : ProductdetailsComponent},
  { path: 'products/:id/edit', component: AddproductComponent },
  { path: '**', component: ErrorComponent },


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule {

 }

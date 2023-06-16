import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './Componets/navbar/navbar.component';
import { LoginComponent } from './Componets/login/login.component';
import { HomeComponent } from './Componets/home/home.component';
import { ProductsComponent } from './Componets/products/products.component';
import { ProductdetailsComponent } from './Componets/productdetails/productdetails.component';
import { AddproductComponent } from './Componets/addproduct/addproduct.component';
import { ErrorComponent } from './error/error.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    LoginComponent,
    HomeComponent,
    ProductsComponent,
    ProductdetailsComponent,
    AddproductComponent,
    ErrorComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

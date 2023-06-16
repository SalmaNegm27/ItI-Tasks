import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Componets/home/home.component';
import { LoginComponent } from './Componets/login/login.component';
import { ErrorComponent } from './error/error.component';
import { ProductsComponent } from './Componets/products/products.component';
const routes: Routes = [
  {path:'home',component : HomeComponent},
  {path:'login', component : LoginComponent},
 
  // { path: '**', component: ErrorComponent },
  {path : 'products',component: ProductsComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule {

 }

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ProductsComponent } from './pages/products/products.component';
import { CustomersComponent } from './pages/customers/customers.component';
import { HomeComponent } from './pages/home/home.component';
import { AuthComponent } from './pages/auth/auth.component';
import { CustomerFormComponent } from './pages/customers/customer-form/customer-form.component';
import { ProductFormComponent } from './pages/products/product-form/product-form.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'customers', component: CustomersComponent },
  { path: 'customer', component: CustomerFormComponent },
  { path: 'customer/:id', component: CustomerFormComponent },
  { path: 'products', component: ProductsComponent },
  { path: 'product', component: ProductFormComponent },
  { path: 'product/:id', component: ProductFormComponent },
  { path: 'login', component: AuthComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

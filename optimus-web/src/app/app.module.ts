import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatTableModule } from '@angular/material/table';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatDialogModule } from '@angular/material/dialog';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { CustomersComponent } from './pages/customers/customers.component';
import { ProductsComponent } from './pages/products/products.component';
import { HttpClientModule } from '@angular/common/http';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatGridListModule } from '@angular/material/grid-list';
import { NgChartsModule } from 'ng2-charts';
import { NavComponent } from './pages/nav/nav.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { HomeComponent } from './pages/home/home.component';
import { MatMenuModule } from '@angular/material/menu';
import { AuthComponent } from './pages/auth/auth.component';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatRadioModule } from '@angular/material/radio';
import { ReactiveFormsModule } from '@angular/forms';
import { CustomerFormComponent } from './pages/customers/customer-form/customer-form.component';
import { ProductFormComponent } from './pages/products/product-form/product-form.component';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    CustomersComponent,
    ProductsComponent,
    NavComponent,
    HomeComponent,
    AuthComponent,
    CustomerFormComponent,
    ProductFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatToolbarModule,
    MatButtonModule,
    MatCardModule,
    MatIconModule,
    MatTableModule,
    MatSlideToggleModule,
    MatDialogModule,
    MatFormFieldModule,
    MatSnackBarModule,
    MatGridListModule,
    NgChartsModule,
    LayoutModule,
    MatSidenavModule,
    MatListModule,
    MatMenuModule,
    MatInputModule,
    MatSelectModule,
    MatRadioModule,
    ReactiveFormsModule,
    MatPaginatorModule,
    MatSortModule
  ],
  providers: [ ],
  bootstrap: [AppComponent]
})
export class AppModule { }

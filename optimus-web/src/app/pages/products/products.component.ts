import { Component, OnInit } from '@angular/core';
import { IProductListModel } from 'src/app/core/products/product.model';
import { ProductService } from 'src/app/core/products/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  products: IProductListModel[];
  displayedColumns: string[] = [ 'name', 'quantityInStock', 'costPrice', 'salePrice' ];

  constructor(private service: ProductService) {}

  ngOnInit(): void {
    this.service.getAll().subscribe(response => {
      this.products = response;
    });
  }

}

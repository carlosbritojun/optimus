import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IProductListModel } from 'src/app/core/products/product.model';
import { ProductService } from 'src/app/core/products/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  products: IProductListModel[];
  displayedColumns: string[] = [ 'name', 'quantityInStock', 'costPrice', 'salePrice', 'action' ];

  constructor(
    private service: ProductService,
    private router: Router) {}

  ngOnInit(): void {
    this.getAll();
  }

  private getAll(): void {
    this.service.getAll().subscribe(response => {
      this.products = response;
    });
  }

  public delete(id:string): void {
    if (window.confirm('Deseja realmente excluir o produto?'))
    {
      this.service.delete(id).subscribe(response => {
        this.getAll();
      });
    }
  }

  public edit(id:string): void {
    this.router.navigate([`/product/${id}`], )
  }
}

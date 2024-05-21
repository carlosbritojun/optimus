import { Component, OnInit } from '@angular/core';
import { IDashboardModel, IProductTop10, IProductWithoutStockOrZero } from 'src/app/core/dashboard/dashboard.model';
import { DashboardService } from 'src/app/core/dashboard/dashboard.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  dashboard: IDashboardModel;
  productsTop10: any;
  productsWithStockOrZero : any;

  constructor(private service: DashboardService){} 
  
  ngOnInit(): void {
    this.generate();
  }

  private generate() : void {
    this.service.getData().subscribe(response => {
      this.dashboard = response;

      this.setProductsTop10Graph(response.productsTop10);
      this.setProductsWithStockOrZeroGraph(response.productsWithoutStockOrZero);
    });
  }

  private setProductsTop10Graph(products: IProductTop10[]) {

    this.productsTop10 = {
      labels : products.map(product => product.name),
      datasets: [
        {
          data : products.map(product => product.quantityInStock),
          label: '10 Produtos com maior estoque',
          fill: true
        }
      ]
    }
  }

  private setProductsWithStockOrZeroGraph(products: IProductWithoutStockOrZero[]) {
    console.log(this.dashboard.productsWithoutStockOrZero);
    this.productsWithStockOrZero = {
      labels : products.map(product => product.name),
      datasets: [
        {
          data: products.map(product => product.quantityInStock),
          label: 'Produtos com estoque zerado ou negativos',
          fill: true
        }
      ]
    }
  }
}

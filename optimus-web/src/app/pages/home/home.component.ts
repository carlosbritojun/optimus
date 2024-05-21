import { Component, OnInit } from '@angular/core';
import { map } from 'rxjs/operators';
import { Breakpoints, BreakpointObserver } from '@angular/cdk/layout';
import { IDashboardModel, IProductTop10, IProductWithoutStockOrZero } from 'src/app/core/dashboard/dashboard.model';
import { DashboardService } from 'src/app/core/dashboard/dashboard.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  
  dashboard: IDashboardModel;
  productsTop10: any;
  productsWithoutStockOrZero : any;
  
  cards = this.breakpointObserver.observe(Breakpoints.Handset).pipe(
    map(({ matches }) => {
      if (matches) {
        return [
          { title: 'Produtos (Top 10)', cols: 1, rows: 1 , type: "top10Chart" },
          { title: 'Total de Clientes', cols: 1, rows: 1, type: "totalOfCustomers" },
          { title: 'Produtos (Sem estoque no negativos)', cols: 1, rows: 1, type: "withNegativeOrZero" },
          { title: 'Total de Produtos', cols: 1, rows: 1, type: "totalOfProducts" }
        ];
      }

      return [
        { title: 'Produtos (Top 10)', cols: 2, rows: 1, type: "top10Chart" },
        { title: 'Total de Clientes', cols: 1, rows: 1, type: "totalOfCustomers" },
        { title: 'Produtos (Sem estoque no negativos)', cols: 1, rows: 2, type: "withNegativeOrZero" },
        { title: 'Total de Produtos', cols: 1, rows: 1, type: "totalOfProducts" }
      ];
    })
  );

  ngOnInit(): void {
    this.generate();
  }

  constructor(private breakpointObserver: BreakpointObserver, private service: DashboardService) {}
  

  private generate() : void {
    this.service.getData().subscribe(response => {
      this.dashboard = response;

      this.setProductsTop10Graph(response.productsTop10);
      this.setProductsWithoutStockOrZeroGraph(response.productsWithoutStockOrZero);
    });
  }

  private setProductsTop10Graph(tops: IProductTop10[]) {

    this.productsTop10 = {
      labels : tops.map(product => product.name),
      datasets: [
        {
          data : tops.map(product => product.quantityInStock),
          label: '10 Produtos com maior estoque',
          fill: true
        }
      ]
    }
  }

  private setProductsWithoutStockOrZeroGraph(zeros: IProductWithoutStockOrZero[]) {
    
    this.productsWithoutStockOrZero = {
      labels : zeros.map(product => product.name),
      datasets: [
        {
          data: zeros.map(product => product.quantityInStock),
          label: 'Produtos com estoque zerado ou negativos',
          fill: true
        }
      ]
    }
  }
}

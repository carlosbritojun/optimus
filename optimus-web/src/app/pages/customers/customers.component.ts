import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ICustomerListModel } from 'src/app/core/customers/customer.model';
import { CustomerService } from 'src/app/core/customers/customer.service';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {
  
  customers: ICustomerListModel[];
  displayedColumns: string[] = ['name', 'email', 'action'];
  
  constructor(private service: CustomerService, private router: Router){}
  
  ngOnInit(): void {
    this.getAll();
  }

  private getAll(): void {
    this.service.getAll().subscribe(response => {
      this.customers = response;
    });
  }

  public delete(id:string): void {
    //Modificar para Dialog do Material
    if (window.confirm('Deseja realmente excluir o cliente?'))
    {
      this.service.delete(id).subscribe(response => {
        this.getAll();
      })
    }
  }

  public edit(id:string): void {
    this.router.navigate([`/customer/${id}`], )
  }
}

import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { ICustomerListModel } from 'src/app/core/customers/customer.model';
import { CustomerService } from 'src/app/core/customers/customer.service';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {
  
  customers: ICustomerListModel[];
  displayedColumns: string[] = ['name','email'];
  
  constructor(private service: CustomerService){}
  
  ngOnInit(): void {
    this.service.getAll().subscribe(response => {
      this.customers = response;
    });
  }
}

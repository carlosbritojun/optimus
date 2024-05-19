import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICustomerListModel } from './customer.model';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http: HttpClient) { }

  getAll() : Observable<ICustomerListModel[]> {
    return this.http.get<ICustomerListModel[]>("http://localhost:3000/customers")
  }
}

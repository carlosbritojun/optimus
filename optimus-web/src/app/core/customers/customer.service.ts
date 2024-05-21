import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICustomerListModel, ICustomerModel } from './customer.model';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http: HttpClient) { }

  getById(id: string) : Observable<any | null> {
    return this.http.get<any>("http://localhost:5219/api/v1/customers/" + id);
  }

  getAll() : Observable<ICustomerListModel[]> {
    return this.http.get<ICustomerListModel[]>("http://localhost:5219/api/v1/customers");
  }

  delete(id:string) : Observable<any> {
    return this.http.delete("http://localhost:5219/api/v1/customers/" + id);
  }

  add(model: any): Observable<any> {
    return this.http.post("http://localhost:5219/api/v1/customers", model);
  }

  update(id: string, model: any): Observable<any> {
    return this.http.put("http://localhost:5219/api/v1/customers/" + id, model);
  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { ICustomerListModel } from './customer.model';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http: HttpClient) { }

  getById(id: string) : Observable<any | null> {
    return this.http.get<any>(`${environment.apiUrl}api/v1/customers/${id}`);
  }

  getAll() : Observable<ICustomerListModel[]> {
    return this.http.get<ICustomerListModel[]>(`${environment.apiUrl}api/v1/customers`);
  }

  delete(id:string) : Observable<any> {
    return this.http.delete(`${environment.apiUrl}api/v1/customers/${id}`);
  }

  add(model: any): Observable<any> {
    return this.http.post(`${environment.apiUrl}api/v1/customers`, model);
  }

  update(id: string, model: any): Observable<any> {
    return this.http.put(`${environment.apiUrl}api/v1/customers/${id}`, model);
  }
}

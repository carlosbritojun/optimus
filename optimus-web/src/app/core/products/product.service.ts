import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IProductListModel } from './product.model';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }
  
  getById(id: string) : Observable<any> {
    return this.http.get<any>(`${environment.apiUrl}api/v1/products/${id}`);
  }

  getAll() : Observable<IProductListModel[]> {
    return this.http.get<IProductListModel[]>(`${environment.apiUrl}api/v1/products`);
  }

  delete(id: string) : Observable<any> {
    return this.http.delete(`${environment.apiUrl}api/v1/products/${id}`);
  }

  add(model: any): Observable<any> {
    return this.http.post(`${environment.apiUrl}api/v1/products`, model);
  }

  update(id: string, model: any): Observable<any> {
    return this.http.put(`${environment.apiUrl}api/v1/products/${id}`, model);
  }
}

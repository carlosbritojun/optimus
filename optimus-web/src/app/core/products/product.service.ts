import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IProductListModel, IProductModel } from './product.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }
  
  getById(id: string) : Observable<any> {
    return this.http.get<any>("http://localhost:5219/api/v1/products/" + id);
  }

  getAll() : Observable<IProductListModel[]> {
    return this.http.get<IProductListModel[]>("http://localhost:5219/api/v1/products");
  }

  delete(id: string) : Observable<any> {
    return this.http.delete("http://localhost:5219/api/v1/products/" + id);
  }

  add(model: any): Observable<any> {
    return this.http.post("http://localhost:5219/api/v1/products", model);
  }

  update(id: string, model: any): Observable<any> {
    return this.http.put("http://localhost:5219/api/v1/products/" + id, model);
  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { IDashboardModel } from './dashboard.model';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {

  constructor(private http: HttpClient) { }

  getData() : Observable<IDashboardModel> {
    return this.http.get<IDashboardModel>("http://localhost:3000/dashboard");
  }
}

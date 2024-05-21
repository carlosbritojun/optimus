import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IUserModel } from './auth.model';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient, private router: Router) { }
  
  login(model: any) : Observable<IUserModel> {
    return this.http.post<IUserModel>(`${environment.apiUrl}api/v1/auth`, model);
  }

  storeUser(user: any): void  {
    localStorage.setItem("optimus-user", JSON.stringify(user));
    
  }

  logout(): void {
    localStorage.clear();
    this.router.navigateByUrl('/login');
  }

  isAuthenticated(): boolean {
    const user = localStorage.getItem("optimus-user");
    return !user;
  }

  getCurrentUser() : any {
    return JSON.parse(localStorage.getItem('optimus-user') || '{}');
  }
}

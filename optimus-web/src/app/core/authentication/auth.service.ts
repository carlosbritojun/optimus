import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { ILoginModel, IUserModel } from './auth.model';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private loggedIn = new BehaviorSubject<boolean>(false);
  isLoggedIn$ = this.loggedIn.asObservable();

  constructor(private http: HttpClient, private router: Router) { }
  
  login(model: any) : Observable<IUserModel> {
    return this.http.post<IUserModel>("http://localhost:5219/api/v1/auth", model);
  }

  storeUser(user: any): void  {
    localStorage.setItem("optimus-user", JSON.stringify(user));
    this.loggedIn.next(true);
  }

  logout(): void {
    localStorage.clear();
    this.loggedIn.next(false);
    this.router.navigate(['/login']);
  }

  isAuthenticated(): boolean {
    const user = localStorage.getItem("optimus-user");
    return !user;
  }
}

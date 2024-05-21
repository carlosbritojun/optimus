import { HttpStatusCode } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ILoginModel, IUserModel } from 'src/app/core/authentication/auth.model';
import { AuthService } from 'src/app/core/authentication/auth.service';
import { ApiResult } from 'src/app/core/utils/api-result';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.css']
})
export class AuthComponent {
  loginForm = this.fb.group({
    email: [null, [Validators.required, Validators.email]],
    password: [null, Validators.required],
  });

  messages: string[] = [];

  constructor(
    private fb: FormBuilder, 
    private service: AuthService,
    private router: Router) {}

  onSubmit(): void {
    this.service.login(this.loginForm.value).subscribe(result => {
      this.service.storeUser(result);
      this.router.navigate(['home']);
    }, err => { 
      console.log(err);
      this.showValidatonErrors(err) 
    });
  }

  private showValidatonErrors(err: any): void {
    if (err.status === HttpStatusCode.BadRequest) {
      this.messages = ApiResult.normalizeErrors(err);
    }
  }
}

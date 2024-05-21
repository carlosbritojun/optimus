import { HttpStatusCode } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CustomerService } from 'src/app/core/customers/customer.service';
import { ApiResult } from 'src/app/core/utils/api-result';

@Component({
  selector: 'app-customer-form',
  templateUrl: './customer-form.component.html',
  styleUrls: ['./customer-form.component.css']
})

export class CustomerFormComponent implements OnInit {
  
  customerForm = this.fb.group({
    name: [null, Validators.required],
    email: [null, [Validators.required, Validators.email]],
    cpf: [null, Validators.required],
    phone: [null, Validators.required],
    address: [null, Validators.required],
    comments: null
  });

  id: string;
  messages: string[] = [];

  constructor(
    private fb: FormBuilder, 
    private service: CustomerService, 
    private router: Router,
    private route: ActivatedRoute) {}

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id'];
    this.populateForm();
  }

  public populateForm(): void {
    if (this.id) {
      this.service.getById(this.id).subscribe(res => {
        this.customerForm.controls['name'].setValue(res.name);
        this.customerForm.controls['email'].setValue(res.email);
        this.customerForm.controls['cpf'].setValue(res.cpf);
        this.customerForm.controls['phone'].setValue(res.phone);
        this.customerForm.controls['address'].setValue(res.address);
        this.customerForm.controls['comments'].setValue(res.comments);
      });
    }
  }

  onSubmit(): void {
    if (!this.id) {
      this.add();
    } else { 
      this.update();
    }
  }

  add() : void {
    this.service.add(this.customerForm.value).subscribe(response => {
      this.router.navigateByUrl('/customers');
    }, err => {
      console.log(err);
      this.showValidatonErrors(err);
    });
  }

  update(): void {
    this.service.update(this.id, this.customerForm.value).subscribe(response => {
      this.router.navigateByUrl('/customers');
    }, err => {
      console.log(err);
      this.showValidatonErrors(err);
    });
  }

  private showValidatonErrors(err: any): void {
    if (err.status === HttpStatusCode.BadRequest) {
      this.messages = ApiResult.normalizeErrors(err);
    }
  }
}

import { HttpStatusCode } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductService } from 'src/app/core/products/product.service';
import { ApiResult } from 'src/app/core/utils/api-result';

@Component({
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})

export class ProductFormComponent implements OnInit {

  id: string;
  messages: string[] = [];

  productForm = this.fb.group({
    name: [null, Validators.required],
    quantityInStock: [null, Validators.required],
    costPrice: [null, Validators.required],
    salePrice: [null, Validators.required],
    comments: null
  });

  constructor(
    private fb: FormBuilder, 
    private service: ProductService, 
    private router: Router,
    private route: ActivatedRoute) {}

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id'];
    this.populateForm();
  }

  public populateForm(): void {
    if (this.id) {
      this.service.getById(this.id).subscribe(res => {
        this.productForm.controls['name'].setValue(res.name);
        this.productForm.controls['quantityInStock'].setValue(res.quantityInStock);
        this.productForm.controls['costPrice'].setValue(res.costPrice);
        this.productForm.controls['salePrice'].setValue(res.salePrice);
        this.productForm.controls['comments'].setValue(res.comments);
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
    this.service.add(this.productForm.value).subscribe(response => {
      this.router.navigateByUrl('/products');
    }, err => {
      console.log(err);
      this.showValidatonErrors(err);
    });
  }

  update(): void {
    this.service.update(this.id, this.productForm.value).subscribe(response => {
      this.router.navigateByUrl('/products');
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

import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms'
import { CustomerService } from '../shared/customer.service'
import { ToastrService } from 'ngx-toastr'

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  constructor(private customerService: CustomerService, private toastr: ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.reset();
    this.customerService.selectedCustomer = {
      CustomerId: null,
      FirstName: '',
      LastName: '',
      CPF: '',
      Email: ''
    }
  }

  onSubmit(form: NgForm) {
    if (form.value.CustomerId == null) {
      this.customerService.postCustomer(form.value)
        .subscribe(data => {
          this.resetForm(form);
          this.customerService.getCustomerList();
          this.toastr.success('Cliente criado com sucesso');
        })
    }
    else {
      this.customerService.putCustomer(form.value.CustomerId, form.value)
      .subscribe(data => {
        this.resetForm(form);
        this.customerService.getCustomerList();
        this.toastr.info('Cliente alterado com sucesso');
      });
    }
  }
}

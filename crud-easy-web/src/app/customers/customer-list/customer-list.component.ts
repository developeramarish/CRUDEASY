import { Component, OnInit } from '@angular/core';

import { CustomerService } from '../shared/customer.service'
import { Customer } from '../shared/customer.model';
import { ToastrService } from 'ngx-toastr';
@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
 // styleUrls: ['./customer-list.component.css']
})
export class CustomerListComponent implements OnInit {

  constructor(private customerService: CustomerService,private toastr : ToastrService) { }

  ngOnInit() {
    this.customerService.getCustomerList();
  }

  showForEdit(pro: Customer) {
    console.log(pro);
    this.customerService.selectedCustomer = Object.assign({}, pro);;
  }


  onDelete(id: number) {
    if (confirm('Tem certeza ?') == true) {
      this.customerService.deleteCustomer(id)
      .subscribe(x => {
        this.customerService.getCustomerList();
        this.toastr.warning("Cliente deletado com sucesso");
      })
    }
  }
}

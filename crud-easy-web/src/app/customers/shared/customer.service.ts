import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

import {Customer} from'./Customer.model'

@Injectable()
export class CustomerService {

  selectedCustomer : Customer;
  customerList : Customer[];
  constructor(private http : Http) { }

  postCustomer(cust : Customer){
    var body = JSON.stringify(cust);

    var headerOptions = new Headers({'Content-Type':'application/json; charset=utf-8'});
    let options = new RequestOptions({ headers: headerOptions });
    return this.http.post('http://localhost:25859/api/Customer',body,options).map(x => x.json());
  }

  putCustomer(id, cust) {
    var body = JSON.stringify(cust);
    var headerOptions = new Headers({'Content-Type':'application/json; charset=utf-8'});
    let options = new RequestOptions({ headers: headerOptions });
    return this.http.put('http://localhost:25859/api/Customer/' + id,
      body,
      options).map(res => res.json());
  }
  getCustomerList(){
    this.http.get('http://localhost:25859/api/Customer')
    .map((data : Response) =>{
      return data.json() as Customer[];
    }).toPromise().then(x => {
      this.customerList = x;
    })
  }

  deleteCustomer(id: number) {
    return this.http.delete('http://localhost:25859/api/Customer/' + id).map(res => res.json());
  }
}

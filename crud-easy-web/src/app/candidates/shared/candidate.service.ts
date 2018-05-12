import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions, RequestMethod } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';

import { Candidate} from'./Candidate.model'
import { Bank } from'./Bank.model'

@Injectable()
export class CandidateService {

  selectedCandidate : Candidate;
  candidateList : Candidate[];
  constructor(private http : Http) { }

  postCandidate(can : Candidate){
    var body = JSON.stringify(can);
    console.log(can);
    var headerOptions = new Headers({'Content-Type':'application/json; charset=utf-8'});
    let options = new RequestOptions({ headers: headerOptions });
    return this.http.post('http://localhost:25859/api/Candidate',body,options).map(x => x.json());
  }

  putCandidate(id, cust) {
    var body = JSON.stringify(cust);
    var headerOptions = new Headers({'Content-Type':'application/json; charset=utf-8'});
    let options = new RequestOptions({ headers: headerOptions });
    return this.http.put('http://localhost:25859/api/Candidate/' + id,
      body,
      options).map(res => res.json());
  }
  getCandidateList(){
    this.http.get('http://localhost:25859/api/Candidate')
    .map((data : Response) =>{
      return data.json() as Candidate[];
    }).toPromise().then(x => {
      this.candidateList = x;
    })
  }

  deleteCandidate(id: number) {
    return this.http.delete('http://localhost:25859/api/Candidate/' + id).map(res => res.json());
  }
}

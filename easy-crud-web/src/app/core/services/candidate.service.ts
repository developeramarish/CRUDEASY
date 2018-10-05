import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Candidate } from '../models/candidate';

@Injectable()
export class CandidateService {

  constructor(private _http: HttpClient) { }

  public create(candidate: Candidate) {
    delete candidate.id;
    return this._http.post<any>(`http://localhost:5982/api/candidates`, candidate);
  }

}

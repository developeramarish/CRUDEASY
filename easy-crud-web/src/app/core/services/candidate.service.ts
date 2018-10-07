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

  public getAll() {
    return this._http.get<Candidate[]>(`http://localhost:5982/api/candidates`);
  }

  public getById(id: string) {
    return this._http.get<Candidate>(`http://localhost:5982/api/candidates/${id}`);
  }

  public update(candidate: Candidate) {
    return this._http.put<any>(`http://localhost:5982/api/candidates/${candidate.id}`, candidate);
  }

  public delete(id: string) {
    return this._http.delete<any>(`http://localhost:5982/api/candidates/${id}`);
  }

}

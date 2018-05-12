import { Component, OnInit } from '@angular/core';

import {CandidateService} from './shared/candidate.service'
@Component({
  selector: 'app-candidates',
  templateUrl: './candidates.component.html',
  styleUrls: ['./candidates.component.css'],
  providers:[CandidateService]
})
export class CandidatesComponent implements OnInit {

  constructor(private candidateService : CandidateService) { }

  ngOnInit() {
  }

}

import { Component, OnInit } from '@angular/core';

import { CandidateService } from '../shared/candidate.service'
import { Candidate } from '../shared/candidate.model';
import { ToastrService } from 'ngx-toastr';
@Component({
  selector: 'app-candidate-list',
  templateUrl: './candidate-list.component.html',
 // styleUrls: ['./Candidate-list.component.css']
})
export class CandidateListComponent implements OnInit {

  constructor(private candidateService: CandidateService,private toastr : ToastrService) { }

  ngOnInit() {
    this.candidateService.getCandidateList();
  }

  showForEdit(pro: Candidate) {
    console.log(pro);
    this.candidateService.selectedCandidate = Object.assign({}, pro);;
  }


  onDelete(id: number) {
    if (confirm('Tem certeza ?') == true) {
      this.candidateService.deleteCandidate(id)
      .subscribe(x => {
        this.candidateService.getCandidateList();
        this.toastr.warning("Cliente deletado com sucesso");
      })
    }
  }
}

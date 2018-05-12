import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms'
import { CandidateService } from '../shared/candidate.service'
import { ToastrService } from 'ngx-toastr'
import { Bank } from '../shared/bank.model';
@Component({
  selector: 'app-candidate',
  templateUrl: './candidate.component.html',
  styleUrls: ['./candidate.component.css']
})
export class CandidateComponent implements OnInit {

  constructor(private candidateService: CandidateService, private toastr: ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.reset();
    this.candidateService.selectedCandidate = {
      CandidateId: null,
      Name:'',
      Email:'',
      SkypeAddress:'',
      Cellphone:'',
      LinkedinAddress:'',
      City:'',
      State:'',
      Portfolio:'',
      FourHours:false,
      FourSixHours:false,
      SixEightHours:false,
      EightHours:false,
      HoursOnWeekends:false,
      Morning:false,
      Afternoon:false,
      Night:false,
      Dawn:false,
      Comercial:false,
      Salary:'',
      CrudLink:'',
      Bank: {},
    }
  }

  onSubmit(form: NgForm) {
    if (form.value.CustomerId == null) {
      this.candidateService.postCandidate(form.value)
        .subscribe(data => {
          this.resetForm(form);
          this.candidateService.getCandidateList();
          this.toastr.success('Cliente criado com sucesso');
        })
    }
    else {
      this.candidateService.putCandidate(form.value.CustomerId, form.value)
      .subscribe(data => {
        this.resetForm(form);
        this.candidateService.getCandidateList();
        this.toastr.info('Cliente alterado com sucesso');
      });
    }
  }
}

import { Component, OnInit } from '@angular/core';
import { Candidate } from '../../../core/models/candidate';
import { FormBuilder, FormGroup, Validators, FormArray, FormControl } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { CandidateService } from '../../../core/services/candidate.service';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  formGroup: FormGroup;
  constructor(private _scCandidate: CandidateService,
     private _formBuilder: FormBuilder) {  this.createFormGroup(); }

  ngOnInit() {
  }

  createFormGroup() {
    this.formGroup = this._formBuilder.group({
      id: '',
      name: ['', ],
      email: ['', ],
      skypeAddress: ['', ],
      cellphone: ['', ],
      linkedinAddress: ['', ],
      city: ['', ],
      state: ['', ],
      portfolio: ['', ],
      fourHours: false,
      fourSixHours: false,
      sixEightHours: false,
      eightHours: false,
      hoursOnWeekends: false,
      comercial: false,
      morning: false,
      night: false,
      afternoon: false,
      dawn: false,
      salary: ['', ],
      crudLink: ['', ],
      recipient: ['', ],
      bankName: ['', ],
      agency: ['', ],
      account: false,
      savings: false,
    });
  }

  onAddCandidate() {
    this._scCandidate.create(this.formGroup.value).subscribe(resp => {
      if (resp.success) {

        }
      }
    );
  }

}

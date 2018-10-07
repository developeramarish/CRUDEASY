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
      salary: [0, ],
      crudLink: ['', ],
      recipient: ['', ],
      bankName: ['', ],
      agency: ['', ],
      account: false,
      savings: false,
      Ionic: [0, ],
      Android: [0, ],
      Ios: [0, ],
      Html: [0, ],
      Css: [0, ],
      Bootstrap: [0, ],
      Jquery: [0, ],
      Angular: [0, ],
      Java: [0, ],
      Asp: [0, ],
      C: [0, ],
      Cplusplus: [0, ],
      Cake: [0, ],
      Django: [0, ],
      Magento: [0, ],
      Php: [0, ],
      Wordpress: [0, ],
      Python: [0, ],
      Ruby: [0, ],
      SqlServer: [0, ],
      MySql: [0, ],
      Salesforce: [0, ],
      Photoshop: [0, ],
      Illustrator: [0, ],
      Seo: [0, ],
      Others: ['', ],
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

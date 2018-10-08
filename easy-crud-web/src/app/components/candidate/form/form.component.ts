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
  itsEditMode: Boolean = false;
  constructor(private _scCandidate: CandidateService,
     private _formBuilder: FormBuilder,
     private _activatedRoute: ActivatedRoute) {  this.createFormGroup(); }

  ngOnInit() {
    this.getBookSaved();
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
      cpfRecipient: ['', ],
      chain: false,
      bankName: ['', ],
      agency: ['', ],
      account: ['', ],
      savings: false,
      ionic: [0, ],
      android: [0, ],
      ios: [0, ],
      html: [0, ],
      css: [0, ],
      bootstrap: [0, ],
      jquery: [0, ],
      angular: [0, ],
      java: [0, ],
      asp: [0, ],
      c: [0, ],
      cplusplus: [0, ],
      cake: [0, ],
      django: [0, ],
      magento: [0, ],
      php: [0, ],
      wordpress: [0, ],
      python: [0, ],
      ruby: [0, ],
      sqlServer: [0, ],
      mySql: [0, ],
      salesforce: [0, ],
      photoshop: [0, ],
      illustrator: [0, ],
      seo: [0, ],
      others: ['', ],
    });
  }


  getBookSaved() {
    let id = '';
    this._activatedRoute.params.subscribe((param) => id = param.id);
    this.itsEditMode = !!id;

    if (id) {
      this._scCandidate.getById(id).subscribe(x => {
        const candidateForUpdate = {
          id: x.id,
          name: x.name,
          email: x.email,
          skypeAddress: x.skypeAddress,
          cellphone: x.cellphone,
          linkedinAddress: x.linkedinAddress,
          city: x.city,
          state: x.state,
          portfolio: x.portfolio,
          fourHours: x.fourHours,
          fourSixHours: x.fourSixHours,
          sixEightHours: x.sixEightHours,
          eightHours: x.eightHours,
          hoursOnWeekends: x.hoursOnWeekends,
          comercial: x.comercial,
          cpfRecipient: x.cpfRecipient,
          chain: x.chain,
          css: x.css,
          bootstrap: x.bootstrap,
          jquery: x.jquery,
          angular: x.angular,
          java: x.java,

          ionic: x.ionic,
          android: x.android,
          ios: x.ios,
          html: x.html,
          morning: x.morning,
          night: x.night,
          afternoon: x.afternoon,
          dawn: x.dawn,
          salary: x.salary,
          crudLink: x.crudLink,
          recipient: x.recipient,
          bankName: x.bankName,
          agency: x.agency,
          account: x.account,
          savings: x.savings,
          asp: x.asp,
          c: x.c,
          cplusplus: x.cplusplus,
          cake: x.cake,
          django: x.django,
          magento: x.magento,
          php: x.php,
          wordpress: x.wordpress,
          python: x.python,
          ruby: x.ruby,
          sqlServer: x.sqlServer,
          mySql: x.mySql,
          salesforce: x.salesforce,
          photoshop: x.photoshop,
          illustrator: x.illustrator,
          seo: x.seo,
          others: x.others

        };
        this.formGroup.setValue(candidateForUpdate);
      }
      );
    }
  }

  onAddCandidate() {
    if (!this.formGroup.value.id) {
      this._scCandidate.create(this.formGroup.value).subscribe(resp => {

        }
      );
    } else {
      this._scCandidate.update(this.formGroup.value).subscribe(resp => {

        }
      );
    }

  }

}

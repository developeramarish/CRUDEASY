import { Component, OnInit } from '@angular/core';
import { LocalDataSource } from 'ng2-smart-table';
import { Router } from '@angular/router';
import { CandidateService } from '../../../core/services/candidate.service';
import { AlertService } from '../../../core/services/alert/alert.service'
@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {
  candidates: LocalDataSource;
  settings: any;



  constructor( private _scCandidate: CandidateService,
    private _router: Router, private _scAlert: AlertService) {}

  ngOnInit() {

    this._scCandidate.getAll().subscribe( resp => {
      console.log(resp);
      this.candidates = new LocalDataSource(resp);

    }
    );
    const btnDelete = '<span class="btn btn-danger btn-sm"> <i class="fa fa-trash"></i> </span>';
    const btnEdit = '<span class="btn btn-info btn-sm"> <i class="fa fa-edit"></i> </span>';

    this.settings = {
      mode: 'inline',
      hideSubHeader: true,
      columns: {
        name: {
          title: 'Nome',
          filter: false,
          width: '20%'
        },
        email: {
          title: 'Email',
          filter: false,
          width: '20%'
        },
        skypeAddress: {
          title: 'Skype',
          filter: false,
          width: '20%'
        },
        cellphone: {
          title: 'Telefone',
          filter: false,
          width: '20%'
        },
        portfolio: {
          title: 'Portifólio',
          filter: false,
          width: '20%'
        },
      },
      actions: {
        delete: false,
        edit: false,
        add: false,
        update: false,
        custom: [
          {
            name: 'donate',
            title: btnEdit
          },
          {
            name: 'delete',
            title: btnDelete
          },
        ],
        position: 'right' // left|right
      },
      attr: {
        class: 'table table-bordered'
      }
    };
  }
  onSearch(query: string = '') {
    if (!query) {
      this.candidates.reset();
    } else {
      this.candidates.setFilter([
        // fields we want to include in the search
        {
          field: 'name',
          search: query
        },
        {
          field: 'email',
          search: query
        },
      ], false);
    }
  }
  onCustom(event) {
    if (event.action === 'delete') {
      this._scCandidate.delete(event.data.id).subscribe(resp => {
          this._scAlert.success('Registro removido com sucesso.');
          this.candidates.remove(event.data);
      });
    } else {
      this._router.navigate([`form/${event.data.id}`]);
    }
  }
}

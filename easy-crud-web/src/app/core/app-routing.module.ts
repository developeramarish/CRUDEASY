import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ListComponent as CandidateListComponent } from '../components/candidate/list/list.component';
import { FormComponent as CandidateFormComponent } from '../components/candidate/form/form.component';
const routes: Routes = [
  {
    path: 'form',
    component: CandidateFormComponent
  },
  {
    path: '',
    component: CandidateListComponent
  },
  {
    path: 'form/:id',
    component: CandidateFormComponent,
  },
  // otherwise redirect to home
  {
    path: '**',
    redirectTo: ''
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule {}

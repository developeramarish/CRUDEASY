import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule} from '@angular/forms'
import { HttpModule } from '@angular/http'

import { AppComponent } from './app.component';
import { CandidatesComponent } from './Candidates/Candidates.component';
import { CandidateComponent } from './Candidates/candidate/candidate.component';
import { CandidateListComponent } from './Candidates/candidate-list/candidate-list.component';

import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
@NgModule({
  declarations: [
    AppComponent,
    CandidatesComponent,
    CandidateComponent,
    CandidateListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

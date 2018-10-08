import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './core/app-routing.module';
import { AppComponent } from './app.component';
import { FormComponent } from './components/candidate/form/form.component';
import { ListComponent } from './components/candidate/list/list.component';
import { CandidateService } from './core/services/candidate.service';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { Ng2SmartTableModule } from 'ng2-smart-table';
import { AlertService } from './core/services/alert/alert.service';
import { AlertComponent } from './core/directiva/alert/alert.component';
import { HeaderComponent } from './components/header/header.component';

@NgModule({
  declarations: [
    AppComponent,
    FormComponent,
    ListComponent,
    AlertComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    Ng2SmartTableModule,
  ],
  providers: [CandidateService, AlertService],
  bootstrap: [AppComponent]
})
export class AppModule { }

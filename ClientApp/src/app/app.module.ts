import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AdminloginComponent } from './adminlogin/adminlogin.component';
import { EmployeeloginComponent } from './employeelogin/employeelogin.component';
import { EmployeeaddComponent } from './employeeadd/employeeadd.component';
import { EmployeeeditComponent } from './employeeedit/employeeedit.component';
import { EmployeelistComponent } from './employeelist/employeelist.component';
import { LeaveListComponent } from './leave-list/leave-list.component';
import { LeaveAddComponent } from './leave-add/leave-add.component';
import { LeaveEditComponent } from './leave-edit/leave-edit.component';
import { EmployeeHomeComponent } from './employee-home/employee-home.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    AdminloginComponent,
    EmployeeloginComponent,
    EmployeeaddComponent,
    EmployeeeditComponent,
    EmployeelistComponent,
    LeaveListComponent,
    LeaveAddComponent,
    LeaveEditComponent,
    EmployeeHomeComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

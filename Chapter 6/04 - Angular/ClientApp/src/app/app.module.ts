import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { StudentListComponent } from './student-list/student-list.component';
import { AddStudentComponent } from './add-student/add-student.component';
import { StudentsService } from './students.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    StudentListComponent,
    AddStudentComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: StudentListComponent, pathMatch: 'full' },
      { path: 'addstudent', component: AddStudentComponent },
    ])
  ],
  providers: [StudentsService],
  bootstrap: [AppComponent]
})
export class AppModule { }

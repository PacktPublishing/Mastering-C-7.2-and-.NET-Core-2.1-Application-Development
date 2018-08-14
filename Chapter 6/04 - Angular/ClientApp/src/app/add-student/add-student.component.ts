import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { StudentsService } from '../students.service';
import { Student } from "../student";

@Component({
  selector: 'app-add-student',
  templateUrl: './add-student.component.html',
  styleUrls: ['./add-student.component.css']
})
export class AddStudentComponent {
  public genres: string[];
  public student: Student = {};

  constructor(
    private router: Router,
    private studentsSvc: StudentsService) {
  }

  addStudent() {
    this.studentsSvc.addStudent(this.student)
      .subscribe(() => {
        this.router.navigateByUrl('/');
      });
  }
}

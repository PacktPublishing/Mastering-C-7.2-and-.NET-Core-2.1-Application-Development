import { Component, OnInit } from '@angular/core';

import { StudentsService } from '../students.service';
import { Student } from "../student";
@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {
  public students: Student[];

  constructor(private studentsService: StudentsService) { }

  ngOnInit() {
    this.studentsService.getStudents()
      .subscribe(students => {
        this.students = students;
      });
  }
}

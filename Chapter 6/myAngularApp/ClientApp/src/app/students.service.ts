import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs/Observable";
import { Student } from "./student";
import { log } from 'util';

@Injectable()
export class StudentsService {

  constructor(private httpClient: HttpClient) { }

  // Getting the list of students
  getStudents(): Observable<Student[]> {
    return this.httpClient.get<Student[]>('/api/Students');
  }

  // Adding a new student by calling post
  addStudent(student: Student) {
    return this.httpClient.post('/api/Students', student);
  }
}
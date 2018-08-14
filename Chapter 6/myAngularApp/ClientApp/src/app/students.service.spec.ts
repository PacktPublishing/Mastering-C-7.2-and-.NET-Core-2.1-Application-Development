import { TestBed, inject } from '@angular/core/testing';

import { StudentsService } from './students.service';

describe('StudentsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [StudentsService]
    });
  });

  it('should be created', inject([StudentsService], (service: StudentsService) => {
    expect(service).toBeTruthy();
  }));
});

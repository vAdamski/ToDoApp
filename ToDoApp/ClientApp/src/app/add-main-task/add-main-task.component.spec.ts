import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddMainTaskComponent } from './add-main-task.component';

describe('AddMainTaskComponent', () => {
  let component: AddMainTaskComponent;
  let fixture: ComponentFixture<AddMainTaskComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddMainTaskComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddMainTaskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

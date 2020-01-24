import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CHangePassengerAirplaneComponent } from './change-passenger-airplane.component';

describe('CHangePassengerAirplaneComponent', () => {
  let component: CHangePassengerAirplaneComponent;
  let fixture: ComponentFixture<CHangePassengerAirplaneComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CHangePassengerAirplaneComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CHangePassengerAirplaneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HealthBarsComponent } from './health-bars.component';

describe('HealthBarsComponent', () => {
  let component: HealthBarsComponent;
  let fixture: ComponentFixture<HealthBarsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HealthBarsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HealthBarsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

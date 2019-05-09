import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ContributionPointsComponent } from './contribution-points.component';

describe('ContributionPointsComponent', () => {
  let component: ContributionPointsComponent;
  let fixture: ComponentFixture<ContributionPointsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ContributionPointsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ContributionPointsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MeToYouComponent } from './me-to-you.component';

describe('MeToYouComponent', () => {
  let component: MeToYouComponent;
  let fixture: ComponentFixture<MeToYouComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MeToYouComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MeToYouComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

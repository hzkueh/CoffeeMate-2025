import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FirstContent } from './first-content';

describe('FirstContent', () => {
  let component: FirstContent;
  let fixture: ComponentFixture<FirstContent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FirstContent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FirstContent);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

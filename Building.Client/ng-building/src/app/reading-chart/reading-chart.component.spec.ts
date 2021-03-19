import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReadingChartComponent } from './reading-chart.component';

describe('ReadingChartComponent', () => {
  let component: ReadingChartComponent;
  let fixture: ComponentFixture<ReadingChartComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReadingChartComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReadingChartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

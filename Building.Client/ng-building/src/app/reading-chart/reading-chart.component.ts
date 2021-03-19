import { Component, OnInit } from '@angular/core';
import { ReadingService } from '../shared/reading.service';

@Component({
  selector: 'app-reading-chart',
  // selector: 'ngbd-dropdown-basic',
  templateUrl: './reading-chart.component.html',
  styleUrls: ['./reading-chart.component.css']
})
export class ReadingChartComponent implements OnInit {

  constructor(public service: ReadingService) { }

  ngOnInit() {
    this.service.readingList();
  }

}

import { Component, OnInit } from '@angular/core';
import { ChartDataSets, ChartType } from 'chart.js';
import { Color, Label } from 'ng2-charts';
import { ReadingService } from '../shared/reading.service';

@Component({
  selector: 'app-reading-chart',
  templateUrl: './reading-chart.component.html',
  styleUrls: ['./reading-chart.component.css']
})
export class ReadingChartComponent implements OnInit{

  constructor(public service: ReadingService) {
   }

  ngOnInit(): void {
    this.service.readingList();
  }

  GetValueList(){
    let valueList: number[] = [];

    this.service.list.forEach(element => {
      valueList.push(element.value);
    });

    console.log(this.service.list);

    // return valueList;

    return [5.76, 3.55, 4.66, 3.63, 7.94, 6.55, 3.55, 4, 6.12, 2.56, 5.76, 3.55, 4.66, 3.63, 7.94, 6.55, 3.55, 4, 6.12, 2.56];
  }

  GetTimestampList(){
    let timestampList: string[] = [];

    this.service.list.forEach(element => {
      timestampList.push(element.timestamp.toTimeString());
    });

    // return timestampList;

    return ['6:10, 00: 20, 00:30', '4:40', '5:50', '6:10, 00: 20, 00:30', '4:40', '5:50', '6:10, 00: 20, 00:30', '4:40', '5:50', '6:10, 00: 20, 00:30', '4:40', '5:50',];
  }

  lineChartData: ChartDataSets[] = [
    { data: this.GetValueList(), label: 'Timeseries Data' },
  ];

  lineChartLabels: Label[] = this.GetTimestampList();

  lineChartOptions = {
    responsive: true,
  };

  lineChartColors: Color[] = [
    {
      borderColor: 'red',
      backgroundColor: '#FFFFFF',
    },
  ];

  lineChartLegend = true;
  lineChartPlugins = [];
  lineChartType:ChartType = 'line';

}

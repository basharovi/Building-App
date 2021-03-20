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

  GetDataSet(){
    let valueList: number[] = [];

    this.service.list.forEach(element => {
      valueList.push(element.value);
    });

    let lineChartData: ChartDataSets[] = [
      { data: valueList, label: 'Timeseries Data' },
    ];

    return lineChartData;
  }

  GetLabels(){
    let timestampList: string[] = [];

    this.service.list.forEach(element => {
      timestampList.push(element.timestamp.toString());
    });

    console.log(timestampList);

    return timestampList;
  }

  

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

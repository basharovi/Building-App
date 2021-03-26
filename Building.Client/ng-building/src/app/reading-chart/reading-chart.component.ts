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

  buildingSelect : any = [];
  selected: any;

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

    // console.log(timestampList);

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

  config = {
    displayKey: "balance", // if objects array passed which key to be displayed defaults to description
    search: true,
    limitTo: 3,
  };

  options = [
    {
      _id: "5a66d6c31d5e4e36c7711b7a",
      index: 0,
      balance: "$2,806.37",
      picture: "http://placehold.it/32x32",
      name: "Burns Dalton",
    },
    {
      _id: "5a66d6c3657e60c6073a2d22",
      index: 1,
      balance: "$2,984.98",
      picture: "http://placehold.it/32x32",
      name: "Mcintyre Lawson",
    },
    {
      _id: "5a66d6c31f967d4f3e9d84e9",
      index: 4,
      balance: "$2,141.42",
      picture: "http://placehold.it/32x32",
      name: "Fischer Erickson",
    },
    {
      _id: "5a66d6c34cfa8cddefb31602",
      index: 5,
      balance: "$1,398.60",
      picture: "http://placehold.it/32x32",
      name: "Medina Underwood",
    },
    {
      _id: "5a66d6c3d727c450794226de",
      index: 6,
      balance: "$3,915.65",
      picture: "http://placehold.it/32x32",
      name: "Goldie Barber",
    },
  ];

  filterData(){
    const selectedBuilding = this.buildingSelect?.balance;
    
    console.log(selectedBuilding);
  }

  isInvalidDate(inputDate: { weekday: () => number; }) {
    return inputDate.weekday() === 0;
  }

}

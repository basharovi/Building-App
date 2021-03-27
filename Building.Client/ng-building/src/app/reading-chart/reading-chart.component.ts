import { Component, OnInit } from '@angular/core';
import { ChartDataSets, ChartType } from 'chart.js';
import { Color, Label } from 'ng2-charts';
import { ReadingService } from '../shared/reading.service';
import { DropdownService } from '../shared/dropdown.service';

@Component({
  selector: 'app-reading-chart',
  templateUrl: './reading-chart.component.html',
  styleUrls: ['./reading-chart.component.css']
})
export class ReadingChartComponent implements OnInit{

  constructor(public readingService: ReadingService,
    public dropDownService: DropdownService) {
   }

  ngOnInit(): void {
    this.readingService.readingList();
    this.dropDownService.getBuildingList();
    this.dropDownService.getDataFieldList();
    this.dropDownService.getObjectList();
  }

  buildingSelect : any = [];
  objectSelect : any = [];
  dataFieldSelect : any = [];

  selected: any;

  GetDataSet(){
    let valueList: number[] = [];

    this.readingService.list.forEach(element => {
      valueList.push(element.value);
    });

    let lineChartData: ChartDataSets[] = [
      { data: valueList, label: 'Timeseries Data' },
    ];

    return lineChartData;
  }

  GetLabels(){
    let timestampList: string[] = [];

    this.readingService.list.forEach(element => {
      timestampList.push(element.timestamp.toString());
    });

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
    displayKey: "name", // if objects array passed which key to be displayed defaults to description
    search: true,
    limitTo: 3,
  };

  filterData(){

    this.readingService.readingVm.buildingId = this.buildingSelect?.id;
    this.readingService.readingVm.objectId = this.objectSelect?.id;
    this.readingService.readingVm.dataFieldId = this.dataFieldSelect?.id;
    this.readingService.readingVm.timestampFrom = this.selected?.startDate?.toISOString();
    this.readingService.readingVm.timestampTo = this.selected?.endDate?.toISOString();

    this.readingService.filterList();
  }

  isInvalidDate(inputDate: { weekday: () => number; }) {
    return inputDate.weekday() === 0;
  }

  loadBuildingDD(){
    return this.dropDownService.buildingList;
  }

  loadObjectDD(){
    return this.dropDownService.objectList;
  }

  loadDataFieldDD(){
    return this.dropDownService.dataFieldList;
  }

}

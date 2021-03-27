import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from "@angular/common/http";
import { Reading, ReadingVm } from './reading.model';

@Injectable({
  providedIn: 'root'
})
export class ReadingService {

  formData: Reading= new Reading();
  readingVm = new ReadingVm();

  readonly baseURL = 'https://localhost:44322/api/';
  list: Reading[] = [];

  constructor(private http: HttpClient) { }

  readingList() {
    this.http.get(this.baseURL + "Reading")
      .toPromise()
      .then(res =>this.list = res as Reading[]);
      
  }

  filterList(){
    this.http.get(this.baseURL + "Reading/Filter?" + this.toQueryString(this.readingVm))
    .toPromise()
      .then(res =>this.list = res as Reading[]);
  }

  toQueryString(obj: { [x: string]: any; }){
    let parts = [];
    for(const prop in obj){
      const value = obj[prop];

      if(value != null && value !== undefined){
        parts.push(encodeURIComponent(prop) + '=' + encodeURIComponent(value));
      }

    }
    return parts.join('&');
  }
  
}

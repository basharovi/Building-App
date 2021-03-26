import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Reading } from './reading.model';

@Injectable({
  providedIn: 'root'
})
export class ReadingService {

  formData: Reading= new Reading();
  readonly baseURL = 'https://localhost:44322/api/';
  list: Reading[] = [];

  constructor(private http: HttpClient) { }

  readingList() {
    this.http.get(this.baseURL + "Reading")
      .toPromise()
      .then(res =>this.list = res as Reading[]);
      
  }
}

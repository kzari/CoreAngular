import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class AirplanesDataService {

  constructor(private http: HttpClient) { }

  getAirplanes(){
    return this.http.get('https://localhost:44399/api/airplane');
  }
}

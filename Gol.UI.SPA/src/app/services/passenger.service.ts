import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PassengerService {

  constructor(private http: HttpClient) { }

  addPassenger(passengerName: string){

    var passenger = {
      name: passengerName
    };

    debugger
    return this.http.post('https://localhost:44399/api/passenger', passenger).map((response: Response) =>{
      console.log (response.json());

    this.http.post('https://localhost:44399/api/passenger', passenger);
  }
}

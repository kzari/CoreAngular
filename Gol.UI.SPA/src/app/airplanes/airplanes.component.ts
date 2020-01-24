import { Component, OnInit } from '@angular/core';
import { AirplanesDataService } from '../services/airplanes-data.service';

@Component({
  selector: 'app-airplanes',
  templateUrl: './airplanes.component.html',
  styleUrls: ['./airplanes.component.css']
})
export class AirplanesComponent implements OnInit {

  airplanes: Object;

  constructor(private data: AirplanesDataService) { }

  ngOnInit() {
    this.data.getAirplanes().subscribe(data => {
      this.airplanes = data;
      //console.log(this.airplanes);
    })
  }

}

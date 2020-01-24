import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AirplanesComponent } from './airplanes/airplanes.component';
import { AddPassengerComponent } from './add-passenger/add-passenger.component';
import { CHangePassengerAirplaneComponent } from './change-passenger-airplane/change-passenger-airplane.component';

const routes: Routes = [
  { path: '', component: AirplanesComponent },
  { path: 'airplanes', component: AirplanesComponent },
  { path: 'add-passenger', component: AddPassengerComponent },
  { path: 'change-passenger-airplane', component: CHangePassengerAirplaneComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

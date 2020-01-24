import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PassengerService } from '../services/passenger.service';

@Component({
  selector: 'app-add-passenger',
  templateUrl: './add-passenger.component.html',
  styleUrls: ['./add-passenger.component.css']
})
export class AddPassengerComponent implements OnInit {

  form: FormGroup;
  submitted = false;
  success = false;

  constructor(private formBuilder: FormBuilder, private service: PassengerService) { }

  ngOnInit() {
    this.form = this.formBuilder.group({
      name: ['', Validators.required]
    });
  }

  onSubmit(){
    this.submitted = true;

debugger;

    if(this.form.invalid){
      return;
    }

    this.service.addPassenger(this.form.value.name);

    this.success = true;
  }

}

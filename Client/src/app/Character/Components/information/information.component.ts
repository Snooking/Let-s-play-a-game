import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-information',
  templateUrl: './information.component.html'
})
export class InformationComponent implements OnInit {
  Snooking:string = "./Snooking_L.jpg";

  constructor() { }

  ngOnInit() {
  }

}

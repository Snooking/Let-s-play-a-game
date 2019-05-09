import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-information',
  templateUrl: './information.component.html',
  styleUrls: ['./information.component.scss']
})
export class InformationComponent implements OnInit {
  private Snooking = require("./Snooking_L.jpg");
  constructor() { }

  ngOnInit() {
  }

}

import { Component, OnInit } from '@angular/core';
import { IDashboardModel } from 'src/app/core/dashboard/dashboard.model';
import { DashboardService } from 'src/app/core/dashboard/dashboard.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  dashboard: IDashboardModel;

  constructor(private service: DashboardService){} 
  
  ngOnInit(): void {
    this.service.getData().subscribe(response => {
      this.dashboard = response;
    });
  }
}

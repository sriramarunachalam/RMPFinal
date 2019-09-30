import { Component, OnInit } from '@angular/core';
import {Competency} from './compentency.model';
import { OperationsService } from '../operations.service';

@Component({
  selector: 'app-competency',
  templateUrl: './competency.component.html',
  styleUrls: ['./competency.component.css']
})
export class CompetencyComponent implements OnInit {
  OnProjectEmployees: Competency[];
  

  constructor(private operationService: OperationsService) { }

  ngOnInit() {
    this.operationService.GetProjectEmployees().subscribe(
      (ProjectData)=> {
        this.OnProjectEmployees = ProjectData
      });

  }
  OnBench(){
    this.operationService.GetOnBenchEmployees().subscribe(
      (OnBenchData)=> {
        this.OnProjectEmployees = OnBenchData
      });
  }
  OnProject(){
    this.operationService.GetProjectEmployees().subscribe(
      (ProjectData)=> {
        this.OnProjectEmployees = ProjectData
      });
  }
  OnTraining(){
    this.operationService.GetOnTraningEmployees().subscribe(
      (OnTrainingData)=> {
        this.OnProjectEmployees = OnTrainingData
      });
  }
}

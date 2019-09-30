import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Competency} from './competency/compentency.model';
import {Accounts} from './accounts/accounts.model';


@Injectable({
  providedIn: 'root'
})
export class OperationsService {

  constructor(private Http: HttpClient) { }


  GetProjectEmployees() {
    return this.Http.get<Competency[]>('assets/OnProject.json');
  }

  getToyotaDetails() {
    return this.Http.get<Accounts[]>('assets/Toyota.json');
  }

  GetOnBenchEmployees() {
    return this.Http.get<Competency[]>('assets/OnBench.json');
  }
  GetOnTraningEmployees() {
    return this.Http.get<Competency[]>('assets/OnTraining.json');
  }
}


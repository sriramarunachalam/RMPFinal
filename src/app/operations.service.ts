import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Competency} from './competency/compentency.model';


@Injectable({
  providedIn: 'root'
})
export class OperationsService {

  constructor(private Http: HttpClient) { }


  GetProjectEmployees() {
    return this.Http.get<Competency[]>('assets/OnProject.json');
  }
}

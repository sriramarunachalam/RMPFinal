import { Component, OnInit } from '@angular/core';
import {Accounts} from './accounts.model';

@Component({
  selector: 'app-accounts',
  templateUrl: './accounts.component.html',
  styleUrls: ['./accounts.component.css']
})
export class AccountsComponent implements OnInit {

  DisplayCard: boolean = false;
  DisplaySingleAccount : Accounts;

  CompanyAccounts : Accounts[] = [
    { RequestNumber: 100, Client: 'Toyota', NumDevelopers: 5, Technology: 'Java', 
    StartDate: '4/12/2015', EndDate:'5/15/2016'}, 

    { RequestNumber: 200, Client: 'Ford', NumDevelopers: 10, Technology: '.NET', 
    StartDate: '2/13/2016', EndDate:'3/21/2017'}, 

    { RequestNumber: 300, Client: 'Tesla', NumDevelopers: 8, Technology: 'Java', 
    StartDate: '6/8/2017', EndDate:'11/19/2018'},

    { RequestNumber: 400, Client: 'Audi', NumDevelopers: 10, Technology: '.NET', 
    StartDate: '4/5/2018', EndDate:'8/9/2019'},

    { RequestNumber: 500, Client: 'BMW', NumDevelopers: 12, Technology: '.NET', 
    StartDate: '7/5/2018', EndDate:'10/9/2019'},
  ];

  DisplayAccount(SingleAccount: Accounts) {
    this.DisplayCard = true;
    this.DisplaySingleAccount = SingleAccount;
  }

  CancelCard() {
    this.DisplayCard = false;
  }

  constructor() { }

  ngOnInit() {
  }

}

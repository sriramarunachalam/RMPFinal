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

  CompanyAccounts : Accounts[] = [];

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

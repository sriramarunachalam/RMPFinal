import { Component, OnInit } from '@angular/core';
import { OperationsService } from '../operations.service';
import {Accounts} from '../accounts/accounts.model';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-toyota-account',
  templateUrl: './toyota-account.component.html',
  styleUrls: ['./toyota-account.component.css']
})
export class ToyotaAccountComponent implements OnInit {

  ToyotaAccount: Accounts[] = [];
  DisplayCard: boolean = false;
  DisplaySingleToyota : Accounts;
  DisplayMessage: boolean = false;


  constructor(private operationsService: OperationsService) { }

  ngOnInit() {
    this.operationsService.getToyotaDetails().subscribe(
      (ToyotaData) => {
        this.ToyotaAccount = ToyotaData;
        }
      );
      
  }
  
  DisplayAccount(Toyota: Accounts) {
    this.DisplayCard = true;
    this.DisplaySingleToyota = Toyota;
  }

  CancelCard() {
    this.DisplayCard = false;
  }

  SubmitForm(AccountsForm: NgForm) {
    console.log(AccountsForm);
    this.ToyotaAccount.push(AccountsForm.value);
    this.DisplayMessage = true;
    console.log(this.ToyotaAccount);
    AccountsForm.resetForm();
  }

}

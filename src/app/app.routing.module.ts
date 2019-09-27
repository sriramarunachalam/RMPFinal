import {NgModule} from '@angular/core';
import { Routes, RouterModule } from '@angular/router'; 
import {HomeComponent} from './home/home.component';
import { AccountsComponent } from './accounts/accounts.component';
import { CompetencyComponent } from './competency/competency.component';
import { LoginComponent } from './login/login.component';

const routes: Routes=[
    {path: '', component: HomeComponent },
    {path: 'Home', component: HomeComponent},
    {path: 'Accounts', component: AccountsComponent},
    {path: 'Competency', component: CompetencyComponent},
    {path: 'Login', component: LoginComponent},

    // Create the Routes
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],  // Initialize the Routes
    exports: [RouterModule]   // Export the routes.
})

export class AppRoutingModule {}
// Export the ApproutingModule so that, We can use it in the App Module.
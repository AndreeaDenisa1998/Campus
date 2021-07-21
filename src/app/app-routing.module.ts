import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';             
import { AuthenticationComponent } from './authentication/authentication.component';
import { LoginComponent } from './authentication/login/login.component';
import { AccountComponent } from './account/account.component';
import { RegisterComponent } from './authentication/register/register.component';

const routes: Routes = [
  { path: '', redirectTo: '/authentication', pathMatch: 'full' },
  {
    path: 'authentication',
    component: AuthenticationComponent,
    children: [
      
      { path: 'login', component: LoginComponent},
      { path: 'register', component: RegisterComponent },
    ],
  },
  { path:'account', component:AccountComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}

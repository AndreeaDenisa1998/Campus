import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';             
import { AuthenticationComponent } from './authentication/authentication.component';
import { AccountComponent } from './authentication/login/account/account.component';
import { LoginComponent } from './authentication/login/login.component';
import { RegisterComponent } from './authentication/register/register.component';

const routes: Routes = [
  { path: '', redirectTo: '/authentication', pathMatch: 'full' },
  {
    path: 'authentication',
    component: AuthenticationComponent,
    children: [
      { path: '', redirectTo: '/authentication', pathMatch: 'full' },
      { path: 'login', component: LoginComponent,
        children:[
          {
            path:'account', component:AccountComponent
          }
        ]
      },
      { path: 'register', component: RegisterComponent },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}

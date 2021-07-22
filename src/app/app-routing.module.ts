import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';             
import { AuthenticationComponent } from './authentication/authentication.component';
import { LoginComponent } from './authentication/login/login.component';
import { AccountComponent } from './account/account.component';
import { RegisterComponent } from './authentication/register/register.component';
import { CampusComponent } from './account/campus/campus.component';
import { FacultyComponent } from './account/faculty/faculty.component';
import { StudentsComponent } from './account/students/students.component';

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
  { 
    path:'account', 
    component:AccountComponent,
    children:[
      {path:'campus', component:CampusComponent},
      {path:'faculty', component:FacultyComponent},
      {path:'students', component:StudentsComponent},
    ],
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}

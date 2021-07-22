import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  loginForm!: FormGroup;

  constructor(private router:Router) { }

  ngOnInit(): void {
    this.loginForm=new FormGroup({
      name:new FormControl('',Validators.required),
      email:new FormControl('',Validators.required),
      username:new FormControl('',Validators.required),
      password:new FormControl('',Validators.required),
    });
  }
  onSubmitLogin(): void{
    //this.router.navigateByUrl('account');
    const username=this.loginForm.get('username')?.value;
    const password=this.loginForm.get('password')?.value;

    if(username !=='' && password !== '')
    {
        //this.router.navigateByUrl()
        this.router.navigateByUrl('account');
    }  
  }
  onSubmitRegister(): void{
    //this.router.navigateByUrl('account');
    const name=this.loginForm.get('name')?.value;
    const email=this.loginForm.get('email')?.value;
    const username=this.loginForm.get('username')?.value;
    const password=this.loginForm.get('password')?.value;
  
    if(name !=='' && email !== '' && username !=='' && password !=='')
    {
        //this.router.navigateByUrl()
        this.router.navigateByUrl('account');
    }  
    }
}

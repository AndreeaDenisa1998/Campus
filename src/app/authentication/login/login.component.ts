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
      username:new FormControl('',Validators.required),
      password:new FormControl('',Validators.required),
    });
  }
  onSubmit(): void{
    //this.router.navigateByUrl('account');
    const username=this.loginForm.get('username')?.value;
    const password=this.loginForm.get('password')?.value;

    if(username !=='' && password !== '')
    {
        //this.router.navigateByUrl()
        this.router.navigateByUrl('account');
    }  

  }
}

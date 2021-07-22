import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  registerForm!: FormGroup;

  constructor(private router:Router) { }

  ngOnInit(): void {
    this.registerForm=new FormGroup({
      name:new FormControl('',Validators.required),
      email:new FormControl('',Validators.required),
      username:new FormControl('',Validators.required),
      password:new FormControl('',Validators.required),
    });
  }
  onSubmitRegister(): void{
    //this.router.navigateByUrl('account');
    const name=this.registerForm.get('name')?.value;
    const email=this.registerForm.get('email')?.value;
    const username=this.registerForm.get('username')?.value;
    const password=this.registerForm.get('password')?.value;
  
    if(name !=='' && email !== '' && username !=='' && password !=='')
    {
        //this.router.navigateByUrl()
        this.router.navigateByUrl('account');
    }  
    }
}



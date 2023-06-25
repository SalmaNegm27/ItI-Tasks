import { Router } from '@angular/router';
import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  constructor(private router : Router)
  {
  }
  loginForm= new FormGroup({
    userInput : new FormControl('', [
      Validators.required,
      Validators.minLength(3)]),
    userPassword : new FormControl('',[Validators.required,Validators.pattern('^.{8,}$')])
  });
 

  get getUserName ()
  {
    return this.loginForm.controls['userInput'];
  }
  get getUserPassword ()
  {
    return this.loginForm.controls['userPassword'];
  }
  formOperation(e:any)
  {
    e.preventDefault()
    if (this.loginForm.status == 'VALID')
    {
      this.router.navigate(['./home']);
    }
    
  }

}

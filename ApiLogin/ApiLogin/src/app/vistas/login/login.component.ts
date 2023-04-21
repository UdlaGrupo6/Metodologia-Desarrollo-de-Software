import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ApiService } from '../../servicios/api/api.service';
import { LoginI } from '../../modelos/login.inteface';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  loginForm = new FormGroup({
    usuario : new FormControl('', Validators.required), 
    password : new FormControl('', Validators.required), 
  })

  constructor(private api:ApiService) {}

  ngOInit(): void{

  }

  onLogin(form: LoginI) {
    console.log(form);
    this.api.loginbyUser(form).subscribe(data => {
      console.log(data)
    });
  }
}


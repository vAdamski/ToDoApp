import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserRegister } from '../Models/UserRegister';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  userRegister = new UserRegister();

  constructor(private http: HttpClient, private router: Router) { }

  ngOnInit() {
  }

  sendDataRegisterToBackend() {
    this.http.post("https://localhost:44343/" + "account/" + "register", this.userRegister).subscribe(response => {
      this.router.navigate(['/login']);
    },
      error => {
      });
  }

}

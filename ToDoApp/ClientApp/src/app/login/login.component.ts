import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserLogin } from '../Models/UserLogin';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  userLogin = new UserLogin();

  constructor(private http: HttpClient, private router: Router) { }

  ngOnInit() {
  }

  sendDataLoginToBackend() {
    this.http.post("https://localhost:44343/" + "account/" + "login", this.userLogin).subscribe(response => {
      this.router.navigate(['/todo']);
      window.location.reload();
    },
      error => {
      });
  }

}

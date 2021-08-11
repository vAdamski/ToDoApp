import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  firstName: string;
  lastName: string;

  constructor(private http: HttpClient, private router: Router) { }

  ngOnInit() {
    this.http.get("https://localhost:44343/" + "account/" + "getCurrentUser").subscribe(response => {
      this.firstName = (response as any).firstName;
      this.lastName = (response as any).lastName;
    },
      error => {
      });
  }

  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  logOutUser() {
    this.http.get("https://localhost:44343/" + "account/" + "logOut").subscribe(response => {
      this.router.navigate(['']);
      window.location.reload();
    },
      error => {
      });
  }
}

import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MainTask } from '../Models/MainTask';

@Component({
  selector: 'app-add-main-task',
  templateUrl: './add-main-task.component.html',
  styleUrls: ['./add-main-task.component.css']
})
export class AddMainTaskComponent implements OnInit {

  mainTask = new MainTask();

  constructor(private http: HttpClient, private router: Router) { }

  ngOnInit() {
  }

  addMainTask() {
    this.http.post("https://localhost:44343/" + "ToDoApp/" + "addNewTaskForUser", this.mainTask).subscribe(response => {
      this.router.navigate(['/todo']);
    },
      error => {
      });
  }

}

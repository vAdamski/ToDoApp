import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { error } from 'selenium-webdriver';
import { MainTask } from '../Models/MainTask';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css']
})
export class TodoComponent implements OnInit {

  mainTasks: Array<MainTask>;
  backendResponse: string;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getAllTasksForLoggeInUser();
  }

  getAllTasks() {
    this.http.get<Array<MainTask>>("https://localhost:44343/" + "ToDoApp/" + "getAllTasks").subscribe(response => {
      this.mainTasks = response;
    },
      error => {
        console.log(error);
      });
  }

  getAllTasksForLoggeInUser() {
    this.http.get<Array<MainTask>>("https://localhost:44343/" + "ToDoApp/" + "getAllTasksForLoggedInUser").subscribe(response => {
      this.mainTasks = response;
    },
      error => {
        console.log(error);
      });
  }

  alertInfo(number) {
    alert("Click button with number " + number);
  }

}

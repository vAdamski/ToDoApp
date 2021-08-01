import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { error } from 'selenium-webdriver';

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
    this.getAllTasks();
  }

  getAllTasks() {
    this.http.get<Array<MainTask>>("https://localhost:44343/" + "ToDoApp/" + "getAllTasks").subscribe(response => {
      console.log(response);
      this.mainTasks = response;
    },
      error => {
        console.log(error);
      });
  }

}

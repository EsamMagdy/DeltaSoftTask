import { Task } from './_models/task.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.prod';
import { ResponseModel } from '../shared/models/response.model';
import { AddTask } from './_models/add-task.model';
import { Paging } from '../shared/models/paging.model';

@Injectable({
  providedIn: 'root',
})
export class TaskService {
  markTaskAsDone(taskId: number) {
    return this.http.post<ResponseModel<boolean>>(
      environment.apiUrl + `Task/MarkTaskAsDone?taskId=${taskId}`,
      null
    );
  }
  constructor(private http: HttpClient) {}

  addTask(task: AddTask) {
    return this.http.post<ResponseModel<Task>>(
      environment.apiUrl + `Task/AddTask`,
      task
    );
  }

  getAllTasks(pageNumber: number, pageSize: number) {
    return this.http.get<ResponseModel<Paging<Task[]>>>(
      environment.apiUrl +
        `Task/GetAllTasks?PageNumber=${pageNumber}&PageSize=${pageSize}`
    );
  }
  getAllTasksForUser(pageNumber: number, pageSize: number, userId: string) {
    return this.http.get<ResponseModel<Paging<Task[]>>>(
      environment.apiUrl +
        `Task/GetAllTasksForUser?PageNumber=${pageNumber}&PageSize=${pageSize}&userId=${userId}`
    );
  }
}

import { AddTask } from './_models/add-task.model';
import { AuthService } from './../core/auth/auth.service';
import { TaskService } from './task.service';
import { Component, OnInit, ViewChild } from '@angular/core';
import { Task } from './_models/task.model';
import { Paging } from '../shared/models/paging.model';
import { MenuItem } from 'primeng/api';
import { UserDto } from '../core/auth/user-dto.model';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { ResponseModel } from '../shared/models/response.model';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-task',
  templateUrl: 'task.component.html',
  styleUrls: ['task.component.css'],
})
export class TaskComponent implements OnInit {
  userId: string;
  tasks: Paging<Task[]>;
  pageNumber = 1;
  pageSize = 10;
  isAdmin: boolean;
  items: MenuItem[];
  users: UserDto[];
  minDate = new Date();
  form!: FormGroup;
  currentChecked: boolean;
  @ViewChild('auto') auto: any;
  constructor(
    private taskService: TaskService,
    private authService: AuthService,
    private fb: FormBuilder,
    private toastr: ToastrService
  ) {
    this.form = this.fb.group({
      assignedToUserId: [null, [Validators.required]],
      deliverDate: [null, [Validators.required]],
      description: [
        null,
        [
          Validators.required,
          Validators.minLength(10),
          Validators.maxLength(100),
        ],
      ],
    });
  }
  public get AssignedToUser(): FormControl {
    return this.form.get('assignedToUserId') as FormControl;
  }
  public get DeliverDate(): FormControl {
    return this.form.get('deliverDate') as FormControl;
  }
  public get Description(): FormControl {
    return this.form.get('description') as FormControl;
  }
  ngOnInit(): void {
    this.minDate = new Date();
    this.minDate.setDate(this.minDate.getDate());

    this.authService.user.subscribe((user) => {
      if (!user) return;
      this.userId = user?.getUserId() as string;
      this.isAdmin = user?.isAdmin();
      this.getAllTasks();
    });
  }
  getAllTasks() {
    if (this.isAdmin) this.getAllTasksForAdmin();
    else this.getAllTasksForUser(this.userId);
  }
  getAllTasksForAdmin() {
    this.taskService
      .getAllTasks(this.pageNumber, this.pageSize)
      .subscribe((res) => {
        if (this.tasks && this.tasks.items.length) {
          this.tasks.items.push(...res.data.items);
        } else this.tasks = res.data;
      });
  }
  getAllTasksForUser(userId: string) {
    this.taskService
      .getAllTasksForUser(this.pageNumber, this.pageSize, userId)
      .subscribe((res) => {
        if (this.tasks && this.tasks.items.length) {
          this.tasks.items.push(...res.data.items);
        } else this.tasks = res.data;
      });
  }
  onScroll() {
    if (!this.tasks || !this.tasks.items.length) return;

    this.pageNumber = this.pageNumber + 1;
    this.getAllTasks();
  }
  onMarkTaskDone(taskId: number) {
    Swal.fire({
      title: 'Are you sure?',
      // text: "You won't be able to revert this!",
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Confirm',
      cancelButtonText: 'Cancel',
    }).then((result) => {
      if (result.isConfirmed) {
        this.taskService.markTaskAsDone(taskId).subscribe(
          (res) => {
            let isDone = res.data;
            if (isDone)
              this.tasks.items.find((s) => s.id == taskId).markAsDone = true;
            this.toastr.success('Task Done Successfully');
          },
          (err) => {
            this.toastr.error((<ResponseModel<string>>err.error).message);
          }
        );
        return;
      }
      this.tasks.items.find((s) => s.id == taskId).isChecked = false;
      // this.currentChecked = false;
    });
  }
  onChangeSearch(name: string) {
    this.authService.getUsersByName(name).subscribe((res) => {
      this.users = res.data;
    });
  }
  selectEvent(user: UserDto) {
    this.AssignedToUser.setValue(user.id);
  }
  onSubmit() {
    if (!this.form.valid) return;

    let task = <AddTask>this.form.value;
    this.taskService.addTask(task).subscribe(
      (res) => {
        this.tasks.items.unshift(res.data);
        this.form.reset();
        this.auto.clear();
        this.auto.close();
        this.toastr.success('Task Added Successfully');
      },
      (err) => {
        this.toastr.error((<ResponseModel<string>>err.error).message);
      }
    );
  }
}

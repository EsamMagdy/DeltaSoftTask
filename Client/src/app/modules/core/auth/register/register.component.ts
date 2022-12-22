import { Register } from './../_models/register.model';
import { Component, OnInit } from '@angular/core';
import {
  FormGroup,
  FormBuilder,
  Validators,
  FormControl,
} from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { MessageService } from 'primeng/api';
import { ResponseModel } from 'src/app/modules/shared/models/response.model';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-register',
  templateUrl: 'register.component.html',
  styleUrls: ['register.component.css'],
})
export class RegisterComponent implements OnInit {
  form!: FormGroup;
  error: string = null;
  message: any;
  fieldTextType: boolean;
  constructor(
    private fb: FormBuilder,
    private route: Router,
    private authServices: AuthService,
    private messageService: MessageService,
    private toastr: ToastrService
  ) {
    this.form = this.fb.group({
      email: [
        null,
        [
          Validators.required,
          Validators.pattern('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$'),
        ],
      ],
      password: [null, [Validators.required]],
      username: [null, [Validators.required]],
    });
  }

  ngOnInit(): void {}
  toggleFieldTextType() {
    this.fieldTextType = !this.fieldTextType;
  }
  public get Email(): FormControl {
    return this.form.get('email') as FormControl;
  }

  public get Password(): FormControl {
    return this.form.get('password') as FormControl;
  }
  public get UserName(): FormControl {
    return this.form.get('username') as FormControl;
  }

  onSubmit() {
    if (!this.form.valid) return;

    let register = <Register>this.form.value;
    this.authServices.register(register).subscribe(
      (res) => {
        this.route.navigateByUrl('/task');
      },
      (err) => {
        this.toastr.error((<ResponseModel<string>>err.error).message);
      }
    );
  }
}

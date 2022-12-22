import { Component, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { MessageService } from 'primeng/api';
import { ResponseModel } from 'src/app/modules/shared/models/response.model';
import Swal from 'sweetalert2';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {
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

  onSubmit() {
    if (this.form.valid) {
      this.authServices.login(this.Email.value, this.Password.value).subscribe(
        (res) => {
          this.route.navigateByUrl('/task');
        },
        (err) => {
          this.toastr.error((<ResponseModel<string>>err.error).message);
        }
      );
    }
  }
}

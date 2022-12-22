import { UserDto } from './user-dto.model';
import { ResponseModel } from './../../shared/models/response.model';
import { catchError, tap } from 'rxjs/operators';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { environment } from 'src/environments/environment.prod';
import { User } from './User';
import { Register } from './_models/register.model';
import { LocalStorageService } from '../services/local-storage.service';

interface AuthResponseData {
  username: string;
  email: string;
  token: string;
}

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  getUsersByName(name: string) {
    return this.http.get<ResponseModel<UserDto[]>>(
      environment.apiUrl + `Account/GetTeamMemberUsersByName?name=${name}`
    );
  }
  private readonly url = environment.apiUrl;

  user = new BehaviorSubject<User>(null);
  private tokenTimer: any;
  private helper = new JwtHelperService();

  constructor(
    private http: HttpClient,
    private router: Router,
    private localStorageService: LocalStorageService
  ) {}

  login(email: string, password: string) {
    return this.http
      .post<ResponseModel<UserDto>>(this.url + `Account/login`, {
        email: email,
        password: password,
      })
      .pipe(
        tap((res) => {
          let user = res.data;
          this.handleAuth(email, user.username, user.token, user.roles);
          return user;
        })
      );
  }

  register(register: Register) {
    return this.http
      .post<ResponseModel<UserDto>>(this.url + `Account/Register`, register)
      .pipe(
        tap((res) => {
          let user = res.data;
          this.handleAuth(
            res.data.email,
            user.username,
            user.token,
            user.roles
          );
          return user;
        })
      );
  }
  logout() {
    this.user.next(null);
    this.router.navigate(['/login']);
    localStorage.removeItem('user');
    if (this.tokenTimer) {
      clearTimeout(this.tokenTimer);
    }

    this.tokenTimer = null;
  }

  autoLogin() {
    const user = this.localStorageService.UserData;
    if (!user) {
      return;
    }

    const loadedUser = new User(
      user.email,
      user.username,
      user._token,
      user.roles
    );

    if (loadedUser.token) {
      debugger;
      this.user.next(loadedUser);
      const expireDate =
        this.helper.getTokenExpirationDate(loadedUser.token).getTime() -
        new Date().getTime();

      // const expireDate = 2147483647;

      this.autoLogout(expireDate);
    }
  }

  autoLogout(timeout: number) {
    this.tokenTimer = setTimeout(() => {
      this.logout();
    }, timeout);
  }

  private handleAuth(
    email: string,
    username: string,
    token: string,
    roles: any
  ) {
    debugger;
    const user = new User(email, username, token, roles);

    this.user.next(user);
    this.localStorageService.UserData = user;

    let expireDate = this.helper.getTokenExpirationDate(user.token).getTime();
    // let expireDate = 2147483647;
    this.autoLogout(expireDate);
  }

  private handleError(err: HttpErrorResponse) {
    let message = '';
    switch (err.status) {
      case 404:
        message = 'Please Check your internet connection';
        break;
      case 401:
        message = 'UnAuthorized';
        break;
      default:
        message = err.error;
        break;
      // ...... continue
    }

    return throwError(message);
  }
}

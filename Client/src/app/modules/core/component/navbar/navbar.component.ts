import { DOCUMENT } from '@angular/common';
import { Component, OnInit, OnDestroy, Inject } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';
import { Subscription } from 'rxjs';
import { AuthService } from '../../auth/auth.service';
import { LangService } from '../../services/lang.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss'],
})
export class NavbarComponent implements OnInit, OnDestroy {
  secondaryTheme = false;
  isLangAr!: boolean;
  currentLang!: string;
  htmlTag!: any;
  isScrolled!: boolean;
  isAuthenticated: boolean = false;
  isServicesNavbarActive: boolean = false;
  stepId: string;
  private userSub: Subscription;
  username: string;

  constructor(
    public translate: TranslateService,
    public langService: LangService,
    @Inject(DOCUMENT) private document: Document,
    private router: Router,
    private authServices: AuthService,
    private ar: ActivatedRoute
  ) {
    this.htmlTag = this.document.getElementsByTagName(
      'html'
    )[0] as HTMLHtmlElement;
  }
  ngOnDestroy(): void {}
  ngOnInit(): void {
    this.authServices.user.subscribe((user) => {
      this.isAuthenticated = !!user;
      this.username = user?.username;
    });
  }
  onLogout() {
    this.authServices.logout();
  }
}

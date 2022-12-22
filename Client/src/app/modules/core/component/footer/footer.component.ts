import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.scss'],
})
export class FooterComponent implements OnInit {
  secondaryTheme = false;

  constructor(private router: Router) {}

  ngOnInit() {
    // change footer theme based on DNS
    this.router.events.subscribe((event) => {
      if (event instanceof NavigationEnd && event.url) {
        if (!event.url.includes('home')) {
          this.secondaryTheme = true;
        } else {
          this.secondaryTheme = false;
        }
      }
    });
  }
}

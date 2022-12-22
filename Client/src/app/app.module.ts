import { FooterComponent } from './modules/core/component/footer/footer.component';
import { NavbarComponent } from './modules/core/component/navbar/navbar.component';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {
  HttpClient,
  HttpClientModule,
  HTTP_INTERCEPTORS,
} from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { LoginComponent } from './modules/core/auth/login/login.component';
import { AuthInterceptorService } from './modules/core/interceptors/auth-Interceptor.service';
import { PrimeNGModule } from './modules/shared/primeng.module';
import { HomeComponent } from './pages/home/home.component';
import { LoaderInterceptor } from './modules/core/interceptors/loaderInterceptor.service';
import { SharedModule } from './modules/shared/shared.module';
import { TaskModule } from './modules/task/task.module';
import { InfiniteScrollModule } from 'ngx-infinite-scroll';

@NgModule({
  declarations: [
    NavbarComponent,
    FooterComponent,
    AppComponent,
    HomeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    PrimeNGModule,
    SharedModule,
    ReactiveFormsModule,
    BsDatepickerModule.forRoot(),

    TranslateModule.forRoot({
      defaultLanguage: 'en',
      loader: {
        provide: TranslateLoader,
        useFactory: createTranslateLoader,
        deps: [HttpClient],
      },
      isolate: false,
    }),
    BsDatepickerModule.forRoot(),
    InfiniteScrollModule,
    TaskModule,
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptorService,
      multi: true,
    },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: LoaderInterceptor,
      multi: true,
    },
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}

export function createTranslateLoader(http: HttpClient) {
  return new TranslateHttpLoader(http, './assets/i18n/', '.json');
}

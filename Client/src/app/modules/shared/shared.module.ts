import { CommonModule } from '@angular/common';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { TranslateModule, TranslateLoader } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { AngularSvgIconModule } from 'angular-svg-icon';
import { CKEditorModule } from 'ckeditor4-angular';
import { NgMultiSelectDropDownModule } from 'ng-multiselect-dropdown';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { NgxSpinnerModule } from 'ngx-spinner';
import { ToastrModule } from 'ngx-toastr';
import { MyLoaderComponent } from './components/my-loader/my-loader.component';
import { ImageConversionPipe } from './pipes/imageConversion.pipe';
import { SafeUrlPipe } from './pipes/safeUrl.pipe';
import { SanitizeHtmlPipe } from './pipes/sanitizeHtmlPipe.pipe copy';

@NgModule({
  declarations: [
    MyLoaderComponent,
    SafeUrlPipe,
    ImageConversionPipe,
    SanitizeHtmlPipe,
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  imports: [
    CommonModule,
    HttpClientModule,
    NgxSpinnerModule,
    CKEditorModule,
    AngularSvgIconModule.forRoot(),
    NgMultiSelectDropDownModule.forRoot(),
    ToastrModule.forRoot({
      timeOut: 10000,
      positionClass: 'toast-top-right',
      maxOpened: 1,
    }),
    ReactiveFormsModule,
    RouterModule,
    BsDatepickerModule.forRoot(),
    TranslateModule.forChild({
      loader: {
        provide: TranslateLoader,
        useFactory: HttpLoaderFactory,
        deps: [HttpClient],
      },
      isolate: false,
    }),
  ],
  exports: [
    HttpClientModule,
    NgxSpinnerModule,
    MyLoaderComponent,
    NgMultiSelectDropDownModule,
    ToastrModule,
    ReactiveFormsModule,
    RouterModule,
    CKEditorModule,
    SafeUrlPipe,
    ImageConversionPipe,
    AngularSvgIconModule,
    SanitizeHtmlPipe,
    TranslateModule,
  ],
})
export class SharedModule {}

export function HttpLoaderFactory(http: HttpClient): TranslateHttpLoader {
  return new TranslateHttpLoader(http, './assets/i18n/', '.json');
}

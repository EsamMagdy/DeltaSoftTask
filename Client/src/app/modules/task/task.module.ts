import { InfiniteScrollModule } from 'ngx-infinite-scroll';
import { TaskComponent } from './task.component';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ChartModule } from 'primeng/chart';
import { PrimeNGModule } from '../shared/primeng.module';
import { TaskRoutingModule } from './task-routing.module';
import { AutocompleteLibModule } from 'angular-ng-autocomplete';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';

@NgModule({
  declarations: [TaskComponent],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    TaskRoutingModule,
    ChartModule,
    PrimeNGModule,
    InfiniteScrollModule,
    AutocompleteLibModule,
    BsDatepickerModule.forRoot(),
  ],
})
export class TaskModule {}

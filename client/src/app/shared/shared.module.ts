import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbCarouselModule, NgbDropdownModule, NgbPaginationModule } from '@ng-bootstrap/ng-bootstrap';
import { PagingHeaderComponent } from './components/paging-header/paging-header.component';
import { PagerComponent } from './components/pager/pager.component';
import { OrderTotalsComponent } from './components/order-totals/order-totals.component';
import { ReactiveFormsModule } from '@angular/forms';
import { TextInputComponent } from './components/text-input/text-input.component';
import { CdkStepperModule}  from '@angular/cdk/stepper';
import { StepperComponent } from './Components/stepper/stepper.component';
import { BasketSummaryComponent } from './Components/basket-summary/basket-summary.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    PagingHeaderComponent,
    PagerComponent,
    OrderTotalsComponent,
    TextInputComponent,
    StepperComponent,
    BasketSummaryComponent
  ],
  imports: [
    CommonModule,
    NgbPaginationModule,
    NgbCarouselModule,
    NgbDropdownModule,
    ReactiveFormsModule,
    CdkStepperModule,
    RouterModule


  ],
  exports: [
    NgbPaginationModule,
    PagingHeaderComponent,
    PagerComponent,
    NgbCarouselModule,
    OrderTotalsComponent,
    ReactiveFormsModule,
    NgbDropdownModule,
    TextInputComponent,
    CdkStepperModule,
    StepperComponent,
    BasketSummaryComponent
  ]
})
export class SharedModule { }

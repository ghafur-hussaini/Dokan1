import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import {SalesComponent} from './sales/sales.component';
import { MeToYouComponent } from './me-to-you/me-to-you.component';
import { ShoppingsComponent } from './shoppings/shoppings.component';
import { RepairsComponent } from './repairs/repairs.component';
import { InventoryService } from './Services/inventory.service';
import { SellingBillService } from './Services/selling-bill.service';
import { SaleFactorService } from './Services/sale-factor.service';
import { CustomerService } from './Services/customer.service';
import { PhoneService } from './Services/phone.service';
import { MeToYouService } from './Services/me-to-you.service';




@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
   ShoppingsComponent,
   SalesComponent,
   RepairsComponent,
   MeToYouComponent,
   HomeComponent,
  
  
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'shoppings', component:ShoppingsComponent },
      { path: 'sales', component:SalesComponent },
      { path: 'metoyou', component:MeToYouComponent },
      { path: 'repair', component:RepairsComponent },
      

    ])
  ],
  providers: [InventoryService,
    SellingBillService,
    SaleFactorService,
    CustomerService,
    PhoneService,
    MeToYouService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

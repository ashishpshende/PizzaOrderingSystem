import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app.routing-module';
import { OrderComponent } from './pages/private/order/order/order.component';
import { PaymentComponent } from './pages/private/payment/payment/payment.component';
import { UserProfileComponent } from './pages/private/User/user-profile/user-profile.component';
import { ViewAddressComponent } from './pages/private/User/Address/view-address/view-address.component';
import { AddAddressComponent } from './pages/private/User/Address/add-address/add-address.component';
import { UpdateAddressComponent } from './pages/private/User/Address/update-address/update-address.component';
import { FooterComponent } from './pages/private/footer/footer.component';
import { HeaderComponent } from './pages/private/header/header.component';
import { PizzaMenuComponent } from './pages/private/pizza/pizza-menu/pizza-menu.component';
import {FormsModule} from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    OrderComponent,
    PaymentComponent,
    UserProfileComponent,
    ViewAddressComponent,
    AddAddressComponent,
    UpdateAddressComponent,
    FooterComponent,
    HeaderComponent,
    PizzaMenuComponent     
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

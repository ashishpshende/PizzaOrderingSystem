import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CartComponent } from './pages/private/cart/cart/cart.component';
import { HomeComponent } from './pages/private/home/home.component';
import { OrderComponent } from './pages/private/order/order/order.component';
import { PaymentComponent } from './pages/private/payment/payment/payment.component';
import { PizzaMenuComponent } from './pages/private/pizza/pizza-menu/pizza-menu.component';
import { AddAddressComponent } from './pages/private/User/Address/add-address/add-address.component';
import { UpdateAddressComponent } from './pages/private/User/Address/update-address/update-address.component';
import { ViewAddressComponent } from './pages/private/User/Address/view-address/view-address.component';
import { UserProfileComponent } from './pages/private/User/user-profile/user-profile.component';
import { LoginComponent } from './pages/public/login/login.component';


const routes: Routes = [
    {path: "", pathMatch: "full",redirectTo: "login"},
    { path: 'login', component: LoginComponent }, 
    { path: 'home', component: HomeComponent }, 
    { path: 'pizza-menu', component: PizzaMenuComponent },    
    { path: 'payment', component: PaymentComponent },    
    { path: 'cart', component: CartComponent },    
    { path: 'orders', component: OrderComponent },    
    { path: 'user-profile', component: UserProfileComponent },    
    { path: 'user-add-address', component: AddAddressComponent },    
    { path: 'update-add-address', component: UpdateAddressComponent },    
    { path: 'view-add-address', component: ViewAddressComponent },    



  ];
  @NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
  })
  
  
  export class AppRoutingModule { }
  
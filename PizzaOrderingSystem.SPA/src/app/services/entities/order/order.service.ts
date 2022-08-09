import { Injectable } from '@angular/core';

import { Observable } from 'rxjs';
import { User } from 'src/app/models/UAM/user';
import { catchError, map, tap } from 'rxjs/operators';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { NetworkService } from '../../common/network/network.service';
import { UserService } from '../user/user.service';
import { URLConstants } from 'src/app/constants/constants';
import { Cart } from 'src/app/models/Cart/cart';
import { CartItem } from 'src/app/models/Cart/cart-item';
import { Order } from 'src/app/models/Order/order';
@Injectable({
  providedIn: 'root'
})
export class OrderService {

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  public currentUser:User;
  constructor(private networkService:NetworkService,
    private http: HttpClient,
    private userService:UserService) { 
      this.currentUser  = userService.currentUser;
    }

    getOrder(orderId: number): Observable<Order> {
      return this.http.get<Order>(URLConstants.GET_ORDER)
      .pipe(
        tap(_ => this.networkService.log('fetched Entity')),
        catchError(this.networkService.handleError<Order>('Exception while getting order', new Order()))
        );
    }
    getOrders(userId: number): Observable<Order[]> {
      return this.http.get<Order[]>(URLConstants.GET_ORDERS)
      .pipe(
        tap(_ => this.networkService.log('fetched Entities')),
        catchError(this.networkService.handleError<Order[]>('Exception while getting orders', []))
        );
    }
    canceItem(order:Order):  Observable<Boolean> {
      return this.http.post<boolean>(URLConstants.UPDATE_ORDER, order, this.httpOptions).pipe(
        tap((newEntity: boolean) => this.networkService.log(`Order Status Updated`)),
        catchError(this.networkService.handleError<boolean>('Exception while updating order status'))
      );
    }
}

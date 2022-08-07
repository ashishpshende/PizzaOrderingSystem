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
@Injectable({
  providedIn: 'root'
})
export class CartService {
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  public currentUser:User;
  constructor(private networkService:NetworkService,
    private http: HttpClient,
    private userService:UserService) { 
      this.currentUser  = userService.currentUser;
    }

    getCart(): Observable<Cart> {
      return this.http.get<Cart>(URLConstants.CART_ITEMS)
      .pipe(
        tap(_ => this.networkService.log('fetched Entities')),
        catchError(this.networkService.handleError<Cart>('get', new Cart()))
        );
    }
    addItem(item:CartItem):  Observable<Boolean> {
      return this.http.post<boolean>(URLConstants.ADD_ITEM_TO_CART, item, this.httpOptions).pipe(
        tap((newEntity: boolean) => this.networkService.log(`User Logged In`)),
        catchError(this.networkService.handleError<boolean>('Exception while user login'))
      );
    }
    removeItem(user:User):  Observable<Boolean> {
      return this.http.post<boolean>(URLConstants.REMOVE_ITEM_FROM_CART, user, this.httpOptions).pipe(
        tap((newEntity: boolean) => this.networkService.log(`User Logged In`)),
        catchError(this.networkService.handleError<boolean>('Exception while user login'))
      );
    }
    clear(user:User):  Observable<Boolean> {
      return this.http.post<boolean>(URLConstants.CLEAR_CART, user, this.httpOptions).pipe(
        tap((newEntity: boolean) => this.networkService.log(`User Logged In`)),
        catchError(this.networkService.handleError<boolean>('Exception while user login'))
      );
    }

}

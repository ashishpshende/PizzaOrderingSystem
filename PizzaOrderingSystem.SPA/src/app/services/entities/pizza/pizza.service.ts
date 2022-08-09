import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { URLConstants } from 'src/app/constants/constants';
import { BaseModel } from 'src/app/models/base-model';
import { Pizza } from 'src/app/models/Pizza/pizza';
import { PizzaCheese } from 'src/app/models/Pizza/pizza-cheese';
import { PizzaItem } from 'src/app/models/Pizza/pizza-item';
import { PizzaSuace } from 'src/app/models/Pizza/pizza-suace';
import { PizzaTopping } from 'src/app/models/Pizza/pizza-topping';
import { PizzaBase } from 'src/app/models/Pizza/pizza-base';
import { NetworkService } from '../../common/network/network.service';
import { Subscriber } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { PizzaSize } from 'src/app/models/Pizza/pizza-size';
import { Cart } from 'src/app/models/Cart/cart';
import { CartItem } from 'src/app/models/Cart/cart-item';
@Injectable({
  providedIn: 'root'
})
export class PizzaService {

  pizzas:Pizza[];
  PizzaBases:PizzaBase[];
  pizzaSauces:PizzaSuace[];
  pizzaCheeseList:PizzaCheese[];
  pizzaTopping:PizzaTopping[];
  pizzaSizes:PizzaTopping[];
  authorizationToken:any;
  
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private networkService:NetworkService, private http: HttpClient,) {
    this.pizzas = new Array();
    this.PizzaBases = new Array();
    this.pizzaSizes = new Array();
    this.pizzaSauces = new Array();
    this.pizzaCheeseList = new Array();
    this.pizzaTopping = new Array();
   }

   
  loadPizzaDetails(): void {
    this.getPizzas();
    this.getPizzaBases();    
    this.getPizzaSizes();
    this.getPizzaCheeseList();
    this.getPizzaTopping()
    this.getPizzaBases()

  }

  getPizzas(): Observable<Pizza[]> {
    return this.http.get<Pizza[]>(URLConstants.PIZZAS)
    .pipe(
      tap(_ => this.networkService.log('fetched Entities')),
      catchError(this.networkService.handleError<Pizza[]>('get', []))
    );
  }

 

  getPizzaBases():  Observable<PizzaBase[]> {  
    return this.http.get<PizzaBase[]>(URLConstants.PIZZA_BASES)
    .pipe(
      tap(_ => this.networkService.log('fetched Entities')),
      catchError(this.networkService.handleError<PizzaBase[]>('get', []))
    );
  }

  getPizzaSauses():  Observable<PizzaSuace[]> {
    return this.http.get<Pizza[]>(URLConstants.PIZZA_SAUSES)
    .pipe(
      tap(_ => this.networkService.log('fetched Entities')),
      catchError(this.networkService.handleError<PizzaSuace[]>('get', []))
    );
  }

  getPizzaCheeseList():  Observable<PizzaCheese[]> {
    return this.http.get<PizzaCheese[]>(URLConstants.PIZZA_CHEESE_LIST)
    .pipe(
      tap(_ => this.networkService.log('fetched Entities')),
      catchError(this.networkService.handleError<PizzaCheese[]>('get', []))
    );
  }

  getPizzaSizes():  Observable<PizzaSize[]> {
  
    return this.http.get<PizzaSize[]>(URLConstants.PIZZA_SIZES)
    .pipe(
      tap(_ => this.networkService.log('fetched Entities')),
      catchError(this.networkService.handleError<PizzaSize[]>('get', []))
    );
  }
  getPizzaTopping():  Observable<PizzaTopping[]> {
  
    return this.http.get<PizzaTopping[]>(URLConstants.PIZZA_Topping)
    .pipe(
      tap(_ => this.networkService.log('fetched Entities')),
      catchError(this.networkService.handleError<PizzaTopping[]>('get', []))
    );
  }


  getCartItems(cartItem:CartItem):  Observable<Boolean> {
  
    return this.http.post<boolean>(URLConstants.ADD_ITEM_TO_CART, cartItem, this.httpOptions).pipe(
      tap((newEntity: boolean) => this.networkService.log(`Added Item to Cart`)),
      catchError(this.networkService.handleError<boolean>('Added Item to Cart'))
    );
  }
  addToCart(cartItem:CartItem):  Observable<Boolean> {
  
    return this.http.post<boolean>(URLConstants.ADD_ITEM_TO_CART, cartItem, this.httpOptions).pipe(
      tap((newEntity: boolean) => this.networkService.log(`Added Item to Cart`)),
      catchError(this.networkService.handleError<boolean>('Added Item to Cart'))
    );
  }
  removeItemFromCart(cartItem:CartItem):  Observable<Boolean> {
  
    return this.http.post<boolean>(URLConstants.REMOVE_ITEM_FROM_CART, cartItem, this.httpOptions).pipe(
      tap((newEntity: boolean) => this.networkService.log(`Remove From Cart`)),
      catchError(this.networkService.handleError<boolean>('Remove Item From'))
    );
  }
  clearCart(cart:Cart):  Observable<Boolean> {
  
    return this.http.post<boolean>(URLConstants.CLEAR_CART, cart, this.httpOptions).pipe(
      tap((newEntity: boolean) => this.networkService.log(`Clear Cart`)),
      catchError(this.networkService.handleError<boolean>('Clear Cart'))
    );
  }
}

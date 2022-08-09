import { Component, OnInit } from '@angular/core';
import { Cart } from 'src/app/models/Cart/cart';
import { CartItem } from 'src/app/models/Cart/cart-item';
import { Pizza } from 'src/app/models/Pizza/pizza';
import { PizzaBase } from 'src/app/models/Pizza/pizza-base';
import { PizzaCheese } from 'src/app/models/Pizza/pizza-cheese';
import { PizzaSize } from 'src/app/models/Pizza/pizza-size';
import { PizzaSuace } from 'src/app/models/Pizza/pizza-suace';
import { PizzaTopping } from 'src/app/models/Pizza/pizza-topping';
import { CartService } from 'src/app/services/entities/cart/cart.service';
import { PizzaService } from 'src/app/services/entities/pizza/pizza.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {
  cart: Cart;
  pizza: Pizza;
  options: string[]
  pizzas: Pizza[];
  pizzaSizes: PizzaSize[];
  PizzaBases: PizzaBase[];
  pizzaSauces: PizzaSuace[];
  pizzaCheeseList: PizzaCheese[];
  pizzaTopping: PizzaTopping[];
  constructor(private pizzaService: PizzaService,
    private cartService:CartService) { 
    this.cart = new Cart();
    this.pizza = new Pizza();
    this.pizzas = new Array();
    this.PizzaBases = new Array();
    this.pizzaSizes = new Array();
    this.pizzaSauces = new Array();
    this.pizzaCheeseList = new Array();
    this.pizzaTopping = new Array();
    this.options = new Array();
  }

  ngOnInit(): void {
    this.cartService.getCart().subscribe(entity => {
      this.cart = entity;
    })
    this.pizzaService.getPizzaBases().subscribe(entities => {
      this.PizzaBases = entities;
    })
    this.pizzaService.getPizzaSauses().subscribe(entities => {
      this.pizzaSauces = entities;
    })
    this.pizzaService.getPizzaCheeseList().subscribe(entities => {
      this.pizzaCheeseList = entities;
    })
    this.pizzaService.getPizzaTopping().subscribe(entities => {
      this.pizzaTopping = entities;
    })
    this.pizzaService.getPizzaSizes().subscribe(entities => {
      this.pizzaSizes = entities;
    })
  }

  addToCartButtonClickedFor(pizza: Pizza) {
    this.cart.items.forEach(item => {
      if (pizza.id == item.pizza.id) {       
        pizza.quantity=1;
        var cartItem = new CartItem();
        cartItem.pizza= pizza;
        cartItem.quantity = 1;
        cartItem.totalPrice =  pizza.base.price + pizza.base.price +pizza.base.price +pizza.base.price;  
        this.pizzaService.addToCart(cartItem).subscribe(result => {});
      }
    });
  }
  plusQtyButtonClickedFor(pizza: Pizza) {
    this.cart.items.forEach(item => {
      if (pizza.id == item.id) {
        pizza.quantity++;
        var cartItem = new CartItem();
        cartItem.pizza= pizza;
        cartItem.quantity =  pizza.quantity;
        cartItem.totalPrice =  pizza.base.price + pizza.base.price +pizza.base.price +pizza.base.price;  
        this.pizzaService.addToCart(cartItem).subscribe(result => {});
      }
    });
  }
  minusQtyButtonClickedFor(pizza: Pizza) {
    this.cart.items.forEach(item => {
      if (pizza.quantity == 0) {
        pizza.addedToCart = false;
        var cartItem = new CartItem();
        cartItem.pizza= pizza;
        cartItem.quantity =  pizza.quantity;
        cartItem.totalPrice =  pizza.base.price + pizza.base.price +pizza.base.price +pizza.base.price;  
        this.pizzaService.removeItemFromCart(cartItem).subscribe(result => {});
        return;
      }
      if (pizza.id == item.id) {
        pizza.quantity--;
        var cartItem = new CartItem();
        cartItem.pizza= pizza;
        cartItem.quantity =  pizza.quantity;
        cartItem.totalPrice =  pizza.base.price + pizza.base.price +pizza.base.price +pizza.base.price;  
        this.pizzaService.addToCart(cartItem).subscribe(result => {});
      }
    });
  }
  PizzaBaseClicked(PizzaBase: PizzaBase, pizza: Pizza)
  {
    this.pizzas.forEach(item => {     
      if (pizza.id == item.id) {
        pizza.base = PizzaBase; 
      }
    });
  }
  pizzaSizeClicked( pizzaSize: PizzaSize, pizza: Pizza)
  {
    this.pizzas.forEach(item => {     
      if (pizza.id == item.id) {
        pizza.size = pizzaSize; 
      }
    });
  }
  pizzaCheeseClicked(pizzaCheese: PizzaCheese, pizza: Pizza)
  {
    this.pizzas.forEach(item => {     
      if (pizza.id == item.id) {
        pizza.cheese = pizzaCheese; 
      }
    });
  }
  pizzaToppingClicked(pizzaTopping: PizzaTopping, pizza: Pizza)
  {
    this.pizzas.forEach(item => {     
      if (pizza.id == item.id) {
        pizza.topping = pizzaTopping; 
      }
    });
  }
  pizzaSauceClicked(pizzaSauce: PizzaSuace, pizza: Pizza)
  {
    this.pizzas.forEach(item => {     
      if (pizza.id == item.id) {
        pizza.sauce = pizzaSauce; 
      }
    });
  }
}

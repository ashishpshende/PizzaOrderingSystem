import { AfterViewInit, Component, OnInit } from '@angular/core';
import { Pizza } from 'src/app/models/Pizza/pizza';
import { PizzaCheese } from 'src/app/models/Pizza/pizza-cheese';
import { PizzaSize } from 'src/app/models/Pizza/pizza-size';
import { PizzaSuace } from 'src/app/models/Pizza/pizza-suace';
import { PizzaTopping } from 'src/app/models/Pizza/pizza-topping';
import { PizzaService } from 'src/app/services/entities/pizza/pizza.service';
import { NgForm } from '@angular/forms';
import { FormGroup, Validators, FormControl } from '@angular/forms';
import { PizzaBase } from 'src/app/models/Pizza/pizza-base';

@Component({
  selector: 'app-pizza-menu',
  templateUrl: './pizza-menu.component.html',
  styleUrls: ['./pizza-menu.component.css']
})
export class PizzaMenuComponent implements OnInit, AfterViewInit {
  options: string[]
  pizzas: Pizza[];
  pizzaSizes: PizzaSize[];
  PizzaBases: PizzaBase[];
  pizzaSauces: PizzaSuace[];
  pizzaCheeseList: PizzaCheese[];
  pizzaToppings: PizzaTopping[];


  constructor(private pizzaService: PizzaService) {
    this.pizzaService.loadPizzaDetails();

    this.pizzas = new Array();
    this.PizzaBases = new Array();
    this.pizzaSizes = new Array();
    this.pizzaSauces = new Array();
    this.pizzaCheeseList = new Array();
    this.pizzaToppings = new Array();
    this.options = new Array();

  }
  pizzaForm(pizzaForm: any) {
    // alert(JSON.stringify(pizzaForm));
  }
  ngAfterViewInit(): void {
    this.pizzas = this.pizzaService.pizzas;
    this.PizzaBases = this.pizzaService.PizzaBases;
    this.pizzaSizes = this.pizzaService.pizzaSizes;
    this.pizzaToppings = this.pizzaService.pizzaToppings;
    this.pizzaSauces = this.pizzaService.pizzaSauces;
    this.pizzaCheeseList = this.pizzaService.pizzaCheeseList;
  }

  ngOnInit(): void {

    this.pizzaService.getPizzas().subscribe(entities => {
      this.pizzas = entities;
      this.pizzas.forEach(item => {
        item.quantity = 0;
        item.base = new PizzaBase();
        item.base.id = 1;
        item.base.name = "100% Wheat Thin Crust";
        item.base.price = 50;

        item.size = new PizzaSize();
        item.size.id = 1;
        item.size.name = "Regular";
        item.size.price = 50;

        item.cheese = new PizzaCheese();
        item.cheese.id = 1;
        item.cheese.name = "Regular";
        item.cheese.price = 50;

        item.topping = new PizzaTopping();
        item.topping.id = 1;
        item.topping.name = "Regular";
        item.topping.price = 50;

      });
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
    this.pizzaService.getPizzaToppings().subscribe(entities => {
      this.pizzaToppings = entities;
    })
    this.pizzaService.getPizzaSizes().subscribe(entities => {
      this.pizzaSizes = entities;
    })


  }
  submitForm(form: NgForm) {

    if (!form.valid) {
      return false;
    } else {
      //alert(JSON.stringify(form.value))
    }
    return true;
  }
  addToCartButtonClickedFor(pizza: Pizza) {
    this.pizzas.forEach(item => {
      if (pizza.id == item.id) {
        pizza.addedToCart = true;
        pizza.quantity=1;
      }
    });
  }
  plusQtyButtonClickedFor(pizza: Pizza) {
    this.pizzas.forEach(item => {
      if (pizza.id == item.id) {
        pizza.quantity++;
      }
    });
  }
  minusQtyButtonClickedFor(pizza: Pizza) {
    this.pizzas.forEach(item => {
      if (pizza.quantity == 0) {
        pizza.addedToCart = false;
        return;
      }
      if (pizza.id == item.id) {
        pizza.quantity--;
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
}

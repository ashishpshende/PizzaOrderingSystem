import { Component, OnInit } from '@angular/core';
import { Pizza } from 'src/app/models/Pizza/pizza';
import { PizzaService } from 'src/app/services/entities/pizza/pizza.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  title = 'PizzaOrderingSystem.SPA';
  pizzas: any;
  constructor(private pizzaService:PizzaService) { 
    this.pizzas =  new Array();
  }

  ngOnInit(): void {
    
  

  }
  

}

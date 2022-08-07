import { BaseModel } from "../base-model";
import { PizzaCheese } from "./pizza-cheese";
import { PizzaSize } from "./pizza-size";
import { PizzaSuace } from "./pizza-suace";
import { PizzaTopping } from "./pizza-topping";
import { PizzaBase } from "./pizza-base";

export class Pizza extends BaseModel {
   public addedToCart:boolean;
   public quantity:number;
   public size:PizzaSize;
   public base:PizzaBase;
   public topping:PizzaTopping;
   public cheese:PizzaCheese;
   public sauce:PizzaSuace;

   constructor()
   {
    super()
    this.addedToCart= false;
    this.quantity= 0;
    this.size =  new PizzaSize();
    this.base =  new PizzaBase();
    this.cheese =  new PizzaCheese();
    this.topping =  new PizzaTopping();
    this.size =  new PizzaSize();
    this.sauce =  new PizzaSuace();

   }
}

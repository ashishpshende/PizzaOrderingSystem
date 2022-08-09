import { BaseModel } from "../base-model";
import { Pizza } from "../Pizza/pizza";
import { PizzaItem } from "../Pizza/pizza-item";
import { Cart } from "./cart";

export class CartItem  extends BaseModel{
    public pizza: Pizza;
    public quantity: number;
    public price: number;
    public totalPrice : number;
    constructor()
    {
        super();
        this.totalPrice = 0;
        this.pizza = new Pizza();
        this.quantity = 0;
        this.price = 0;
    }
}

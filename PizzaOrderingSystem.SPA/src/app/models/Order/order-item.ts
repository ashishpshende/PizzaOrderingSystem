import { BaseModel } from "../base-model";
import { CartItem } from "../Cart/cart-item";
import { Pizza } from "../Pizza/pizza";

export class OrderItem extends BaseModel {
    public pizza: Pizza;
    public quantity: Number;
    public price: Number;

    constructor()
    {
        super();
        this.quantity = 0;
        this.price = 0;
        this.pizza = new Pizza();
    }
    public static CreateFrom(cartItem:CartItem)
    {
        var result = new CartItem();
        result.pizza = cartItem.pizza;
        result.quantity =cartItem.quantity;
        result.price = cartItem.price;        
        return result;
    }
}

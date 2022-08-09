import { BaseModel } from "../base-model";
import { Cart } from "../Cart/cart";
import { OrderItem } from "./order-item";

export class Order extends BaseModel {
    
    public items:OrderItem[];
    public price: number;
    constructor()
    {
        super()
        this.price = 0;
        this.items = new Array();
    }
    static CreateFrom(cart:Cart) {
        var result = new Order();
        result.price = cart.price;
        result.items = new Array();
        cart.items.forEach(cartItem => {
            result.items.push(OrderItem.CreateFrom(cartItem));
        });
        return result;
        }
}

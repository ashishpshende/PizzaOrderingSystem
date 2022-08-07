import { BaseModel } from "../base-model";
import { CartItem } from "./cart-item";

export class Cart  extends BaseModel {
    public items: CartItem[]
    public price: number;

    constructor()
    {
        super()
        this.items = new Array();
        this.price = 0;
    }
}


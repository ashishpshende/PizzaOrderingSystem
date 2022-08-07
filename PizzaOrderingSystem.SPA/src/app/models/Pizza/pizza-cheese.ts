import { BaseModel } from "../base-model";

export class PizzaCheese extends BaseModel {
    public price:number;
    constructor()
    {
        super();
        this.price = 0;
    }
}

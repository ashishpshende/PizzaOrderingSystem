import { BaseModel } from "../base-model";

export class PizzaTopping extends BaseModel {
    public price:number;
    constructor()
    {
        super();
        this.price = 0;
    }
}

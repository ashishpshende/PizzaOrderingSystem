import { BaseModel } from "../base-model";

export class PizzaBase extends BaseModel {
    public price:number;
    constructor()
    {
        super();
        this.price = 0;
    }
}

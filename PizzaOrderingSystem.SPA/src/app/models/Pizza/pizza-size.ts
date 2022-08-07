import { BaseModel } from "../base-model";

export class PizzaSize extends BaseModel {
    public price:number;
    constructor()
    {
        super();
        this.price = 0;
    }
}

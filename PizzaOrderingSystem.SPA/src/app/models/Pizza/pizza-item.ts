import { BaseModel } from "../base-model";

export class PizzaItem extends BaseModel 
{
    public price:number;
    constructor()
    {
       
        super();
        this.price = 0;
    }
}

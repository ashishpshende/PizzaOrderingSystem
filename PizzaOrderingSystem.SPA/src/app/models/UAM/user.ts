import { BaseModel } from "../base-model";

export class User extends BaseModel {
    public token: string| undefined;
}

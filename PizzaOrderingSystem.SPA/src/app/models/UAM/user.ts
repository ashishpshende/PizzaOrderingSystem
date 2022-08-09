import { BaseModel } from "../base-model";

export class User extends BaseModel {

    public username: string| undefined;
    public password: string| undefined;
    public token: string| undefined;
}

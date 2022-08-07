import { environment } from "src/environments/environment";

export class Constants {
    
    public static MAXIMUM_NUMBER = 10;

}

export class URLConstants {
    
    public static USER_LOGIN = environment.serverURL+ "/user/login";
    public static USER_LOGOUT = environment.serverURL+ "/user/logout";
    public static USER_PROFILE = environment.serverURL+ "/user/profile";

    public static PIZZAS = environment.serverURL+ "/pizza/all";
    public static PIZZA_BASES = environment.serverURL+ "/pizza/bases";
    public static PIZZA_TOPPINGS = environment.serverURL+ "/pizza/toppings";
    public static PIZZA_CHEESE_LIST = environment.serverURL+ "/pizza/cheeses";
    public static PIZZA_SIZES = environment.serverURL+ "/pizza/sizes";
    public static PIZZA_SAUSES = environment.serverURL+ "/pizza/sauces";

    public static CART_ITEMS = environment.serverURL+ "/cart/items";
    public static ADD_ITEM_TO_CART = environment.serverURL+ "/cart/addItem";
    public static REMOVE_ITEM_FROM_CART = environment.serverURL+ "/cart/removeItem";
    public static CLEAR_CART = environment.serverURL+ "/cart/clear";




}

export class BaseModel {

    public id:number | undefined;
    public name:string| undefined;
    public image:string| undefined;
    public description: string| undefined;
    public createdBy: BaseModel| undefined;
    public createdOn:string| undefined;
    public updatedBy:BaseModel | undefined
    public updatedOn:string| undefined;
    public ImageUrl:string| undefined;
    public  ThumbImageUrl:string| undefined;

    public  FullSizeImageUrl:string| undefined;

    public  Title:string| undefined;

    public  AlternateText :string| undefined;

    constructor()
    {
        
        // this.id = (requestJSON["id"] != null && requestJSON["id"] != undefined) ? requestJSON["id"] : 0;

       
        // this.name = (requestJSON["name"] != null &&  requestJSON["name"] != undefined) ? requestJSON["name"] : "";

        // this.description = (requestJSON["Description"] != null &&  requestJSON["Description"] != undefined) ? requestJSON["Description"] : "";
        // this.createdOn = (requestJSON["CreatedOn"] != null &&  requestJSON["CreatedOn"] != undefined) ? requestJSON["CreatedOn"] : "";
        // this.updatedOn = (requestJSON["UpdatedOn"] != null &&  requestJSON["UpdatedOn"] != undefined) ? requestJSON["UpdatedOn"] : "";
        
        // if(requestJSON.containskey("createdBy"))
        // {
        //     this.createdBy = new BaseModel(requestJSON["createdBy"]);
        // }
        // if(requestJSON.containskey("updatedBy"))
        // {
        //     this.createdBy = new BaseModel(requestJSON["updatedBy"]);
        // }        
        // this.ImageUrl = requestJSON["imageurl"];
        // this.ThumbImageUrl = requestJSON["thumbimageurl"];
        // this.FullSizeImageUrl = requestJSON["fullsizeimageurl"];
        // this.Title = requestJSON["Title"];
        // this.AlternateText = requestJSON["AlternateText"];
    }
    static constructObject(requestJSON:JSON) {
        var result = new BaseModel();
          result.name ="";
        return result;
        }
   static  getDefaultObject() {
       var defaultObject = new BaseModel();      
        return defaultObject;
    }


}
using MongoDB.Bson;
namespace final_mongodb_webapi;

public class UserData
{
    public ObjectId _id { get; set; }
    public string name { get; set; }
    public int age { get; set; }
}


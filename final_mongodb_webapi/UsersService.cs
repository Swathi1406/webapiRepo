using System;
using MongoDB.Driver;
namespace final_mongodb_webapi
{
    public class UsersService
    {
        private readonly IMongoCollection<UserData> _users;

        public UsersService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("test");
            _users = database.GetCollection<UserData >("users");
        }

        public List<UserData> Get()
        {
            return _users.Find(user => true).ToList();
        }
    }
}



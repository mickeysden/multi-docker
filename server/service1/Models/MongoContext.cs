using System;
using MongoDB.Driver;

namespace service1.Models
{
    public class MongoContext
    {
        public static IMongoCollection<MyEntity> GetMongoContext()
        {
            var client = new MongoClient("mongodb://db1:27017");
            var database = client.GetDatabase("DockerTest");
            return database.GetCollection<MyEntity>("MyEntities");
        }
    }
}
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace service1.Models
{
    public class MyEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Value")]
        public string Value { get; set; }
    }
}
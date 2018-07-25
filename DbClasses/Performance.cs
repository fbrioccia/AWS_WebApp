using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MVC_Core.DbClasses
{
    public class Performance
    {

        [BsonId]
        public ObjectId Id {get;set;}
        public DateTime timestamp { get; set; }
        public string type { get; set; }
        public double value { get; set; }
    }
}
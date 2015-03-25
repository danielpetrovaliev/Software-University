using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChatClient
{
    public class Message
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }

        public string Username { get; set; }
    }
}
﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDBDemo
{
    public class PersonModel
    {
        [BsonId] // stored in Mongo as _id. If Guid is passed in as null Mongo will create a new Guid
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel PrimaryAddress { get; set; }

        [BsonElement("dob")]
        public DateTime DateOfBirth { get; set; }
    }
}

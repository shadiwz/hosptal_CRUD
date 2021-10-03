using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace hosptal_CRUD
{
    public class Hosptal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string FantasyName { get; set; }

        public string CNPJ { get; set; }

        public string Email { get; set; }

        public List<AdressDescription> Adress { get; set; }

        public List<PhoneDescription> PhoneNumber { get; set; }

        public class AdressDescription
        {
            public string Adress { get; set; }
            public string Description { get; set; }
        }

        public class PhoneDescription
        {
            public string NickName { get; set; }
            public string Phone { get; set; }
        }
    }
}

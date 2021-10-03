using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace hosptal_CRUD.services
{
    public class HosptalService : IHosptalService
    {
        private readonly IMongoCollection<Hosptal> _doctor;

        public HosptalService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _doctor = database.GetCollection<Hosptal>(settings.CollectionName);
        }

        public List<Hosptal> Get()
        {
            return _doctor.Find(doctor => true).ToList();
        }

        public Hosptal Get(string id)
        {
            return _doctor.Find<Hosptal>(doctor => doctor.Id == id).FirstOrDefault();
        }

        public Hosptal Create(Hosptal doctor)
        {
            _doctor.InsertOne(doctor);
            return doctor;
        }

        public long Update(string id, Hosptal doctoIn)
        {
            return _doctor.ReplaceOne(doctor => doctor.Id == id, doctoIn).ModifiedCount;
        }

        public long Remove(string id)
        {
            var doc = _doctor.DeleteOne(doc => doc.Id == id);
            return doc.DeletedCount;
        }
    }
}

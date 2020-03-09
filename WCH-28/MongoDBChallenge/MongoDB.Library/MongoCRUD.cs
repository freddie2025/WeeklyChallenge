using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace MongoDB.Library
{
	public class MongoCRUD
	{
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        [Obsolete]
        public void UpsertRecord<T>(string table, Guid id, T record)
        {
            var collection = db.GetCollection<T>(table);

            var result = collection.ReplaceOne(
                new BsonDocument("_id", id),
                record,
                new UpdateOptions { IsUpsert = true });
        }

        public List<T> FindRecordByNames<T>(string table, string firstName, string lastName)
        {
            var collection = db.GetCollection<T>(table);
            List<FilterDefinition<T>> filters = new List<FilterDefinition<T>>
            {
                Builders<T>.Filter.Eq("FirstName", firstName),
                Builders<T>.Filter.Eq("LastName", lastName)
            };
            var filterConcatination = Builders<T>.Filter.And(filters);

            return collection.Find(filterConcatination).ToList();
        }
    }
}

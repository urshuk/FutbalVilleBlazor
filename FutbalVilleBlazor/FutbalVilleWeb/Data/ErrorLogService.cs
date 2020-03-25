using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutbalVilleWeb.Data
{
	public class ErrorLogService
	{
        private readonly IMongoCollection<ErrorLog> errorLogs;

        public ErrorLogService(ILoggingDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            errorLogs = database.GetCollection<ErrorLog>(settings.CollectionName);
        }

        public List<ErrorLog> Get() => errorLogs.Find(error => true).ToList();

        public ErrorLog Get(string id) => errorLogs.Find<ErrorLog>(error => error.Id == id).FirstOrDefault();

        public ErrorLog Create(ErrorLog error)
        {
            errorLogs.InsertOne(error);
            return error;
        }

        public void Update(string id, ErrorLog errorIn) => errorLogs.ReplaceOne(error => error.Id == id, errorIn);

        public void Remove(ErrorLog errorIn) => errorLogs.DeleteOne(error => error.Id == errorIn.Id);

        public void Remove(string id) => errorLogs.DeleteOne(error => error.Id == id);
    }
}

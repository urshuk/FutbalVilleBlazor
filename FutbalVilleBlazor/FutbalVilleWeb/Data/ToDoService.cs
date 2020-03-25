using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutbalVilleWeb.Data
{
	public class ToDoService
	{
        private readonly IMongoCollection<ToDoItem> todos;

        public ToDoService(IToDoDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            todos = database.GetCollection<ToDoItem>(settings.CollectionName);
        }

        public List<ToDoItem> Get() => todos.Find(item => true).ToList();

        public ToDoItem Get(string id) => todos.Find<ToDoItem>(item => item.Id == id).FirstOrDefault();

        public ToDoItem Create(ToDoItem item)
        {
            todos.InsertOne(item);
            return item;
        }

        public void Update(string id, ToDoItem itemIn) => todos.ReplaceOne(item => item.Id == id, itemIn);

        public void Remove(ToDoItem itemIn) => todos.DeleteOne(item => item.Id == itemIn.Id);

        public void Remove(string id) => todos.DeleteOne(item => item.Id == id);
    }
}

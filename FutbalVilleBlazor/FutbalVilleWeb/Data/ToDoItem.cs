using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutbalVilleWeb.Data
{
	public class ToDoItem
	{
		public enum ToDoStatus { ToDo, InProcess, Done }

		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Remark { get; set; }
		public int EstimatedHours { get; set; }
		public int ImportanceLevel { get; set; }
		public DateTime Created { get; set; }
		public DateTime? Deadline { get; set; }
		public ToDoStatus Status { get; set; }
	}
}

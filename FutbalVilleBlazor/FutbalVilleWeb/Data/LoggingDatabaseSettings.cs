using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutbalVilleWeb.Data
{
	public class LoggingDatabaseSettings : ILoggingDatabaseSettings
	{
		public string ErrorsCollectionName { get; set; }
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutbalVilleWeb.Data
{
	public class LoggingDatabaseSettings : ILoggingDatabaseSettings
	{
		public string CollectionName { get; set; }
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
	}

	public interface ILoggingDatabaseSettings
	{
		string CollectionName { get; set; }
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
	}
}

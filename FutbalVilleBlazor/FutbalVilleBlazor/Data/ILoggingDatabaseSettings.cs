using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutbalVilleBlazor.Data
{
	public interface ILoggingDatabaseSettings
	{
		string ErrorsCollectionName { get; set; }
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
	}
}

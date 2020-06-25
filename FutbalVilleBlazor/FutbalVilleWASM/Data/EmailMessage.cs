using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutbalVilleWASM.Data
{
	public class EmailMessage
	{
        public string From { get; set; }
        public string FromDisplay { get; set; }
        public string To { get; set; }
        public string ToDisplay { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}

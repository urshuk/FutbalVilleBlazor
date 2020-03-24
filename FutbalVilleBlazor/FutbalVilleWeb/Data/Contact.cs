﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutbalVilleWeb.Data
{
	public class Contact
	{
		[Required]
		public string Name { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		public string Subject { get; set; }
		[Required]
		public string Message { get; set; }
		[Phone]
		public string Phone { get; set; }
	}
}

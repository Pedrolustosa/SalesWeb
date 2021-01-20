using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Models
{
	public class Department
	{
		public int Id { get; set; }

		[Display(Name = "Nome")]
		public string Name { get; set; }
	}
}

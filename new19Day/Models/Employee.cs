﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new19Day.Models
{
	internal class Employee
	{
		public int Id { get; set; }

		[MaxLength(50)]
		public string? Name { get; set; }

		[Range(18,50)]
		public int Age { get; set; }

		[DataType(DataType.Currency)]
		public decimal Salary { get; set; }
		
	}
}

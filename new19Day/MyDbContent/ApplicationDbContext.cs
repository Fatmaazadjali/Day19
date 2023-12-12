using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Text;
using System.Threading.Tasks;
using new19Day.Models;

namespace new19Day.MyDbContent
{
	internal class ApplicationDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-RETJJ6I\\MSSQLS;Initial Catalog=My1Database;Integrated Security=True;TrustServerCertificate=True;");
		}


		
		public DbSet<Employee> Employee { get; set; }
		public DbSet<Department> Department { get; set; }
	}
}

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
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Data Source=Data Source=DESKTOP-RETJJ6I\\MSSQLS;Initial Catalog=MyDatabase;Integrated Security=True;Connect");
		}


		ApplicationDbContext db = new ApplicationDbContext();
		public DbSet<Employee> Employees { get; set; }
	}
}

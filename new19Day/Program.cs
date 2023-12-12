using Azure;
using new19Day.Models;
using new19Day.MyDbContent;

namespace new19Day
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			ApplicationDbContext context = new ApplicationDbContext();

			int x = 5;
			while (x-->0)
			{
				Console.WriteLine("Enter your name:");
				string name = Console.ReadLine();
				Console.WriteLine("Enter your Age:");
				int age = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter your Salary:");
				int salary = int.Parse(Console.ReadLine());

			
			Employee employee = new Employee
			{
				Name = name,
				Age = age,
				Salary = salary

			};
		}
		}

		 
	}
}
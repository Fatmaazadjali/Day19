using new19Day.MyDbContent;

namespace new19Day
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			ApplicationDbContext context = new ApplicationDbContext();
		}
	}
}
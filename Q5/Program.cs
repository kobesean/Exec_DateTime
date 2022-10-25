using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var start = new DateTime(2022, 01, 01);
			Console.WriteLine(start);
			DayOfWeek weekday = start.DayOfWeek;
			Console.WriteLine(weekday);
			var dayaftertomorow = start.AddDays(1);
			var sunday = start.AddDays(1);
			Console.WriteLine(sunday);
			var endday = new DateTime(2022, 12, 31);
			for (DateTime i = sunday; i <= endday; i = i.AddDays(7))
			{
				Console.WriteLine(i.ToString("yyyy/MM/dd"));
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			string lastday = today.ToString("yyyy/MM/dd");
			Console.WriteLine(lastday);
			int days = DateTime.DaysInMonth(today.Year, today.Month);
			Console.WriteLine("本月的最後一天為:" + days);
		}
	}
}

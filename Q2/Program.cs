using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			string today1 = today.ToString("MM/dd");
			Console.WriteLine("今天是:" + today1);
			DateTime nextmonth = today.AddMonths(1);
			string nextmonth1 = nextmonth.ToString("MM/dd");
			Console.WriteLine("圖書歸還時間為:" + nextmonth1);
		}
	}
}

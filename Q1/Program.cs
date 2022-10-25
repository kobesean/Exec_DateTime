using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			string borrowday = today.ToString("yyyy/MM/dd");
			Console.WriteLine("今天是" + borrowday);
			DateTime returntime = today.AddDays(3);
			string returntime1 = returntime.ToString("yyyy/MM/dd");
			Console.WriteLine("DVD歸還時間是" + returntime1);
		}
	}
}

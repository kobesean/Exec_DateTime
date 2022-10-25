using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			string dd = today.ToString("dd");
			int dd2 = Convert.ToInt32(dd);
			Console.WriteLine(dd);

			if (dd2 <= 10)
			{
				Console.WriteLine("上旬");
			}
			else if (dd2 <= 20)
			{
				Console.WriteLine("中旬");
			}
			else if (dd2 <= 31)
			{
				Console.WriteLine("下旬");
			}
		}
	}
}

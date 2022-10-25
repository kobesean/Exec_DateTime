using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Now;
			string hh = today.ToString("HH");
			int hh2 = Convert.ToInt32(hh);
			Console.WriteLine(hh);

			if (hh2 <= 11)
			{
				Console.WriteLine("早安");
			}
			else if (hh2 <= 18)
			{
				Console.WriteLine("午安");
			}
			else if (hh2 <= 23)
			{
				Console.WriteLine("晚安");
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			string firstday = today.ToString("MM月" + "1號");
			Console.WriteLine(firstday);
		}
	}
}

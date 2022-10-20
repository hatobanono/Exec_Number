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
			for (int i = 1; i < 10; i++)
			{
				for (int k = 0; k < 10; k++)
				{
					int number = i * 1100 + k * 11;
					double sqrt = Math.Sqrt(number);
					if (sqrt == Math.Floor(sqrt))
					{
						Console.WriteLine(number);
					}
				}
			}
		}
	}
}

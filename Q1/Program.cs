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
			Console.Write("請輸入數值: ");
			string input = Console.ReadLine();

			int num = Convert.ToInt32(input);

			if (num == 2 || num == 3)
			{
				Console.WriteLine($"{num} 是質數");
			} else if (num % 2 == 0)
			{
				Console.WriteLine($"{num} 不是質數");
			}
			else
			{
				int int1 = 0;
				for (int i = 3; i <= Math.Sqrt(num); i += 2)
				{
					if (num % i == 0)
					{
						int1++;
						break;
					}
				}

				string result = (int1 == 1) ? $"{num} 不是質數" : $"{num} 是質數";
				Console.WriteLine(result);
			}


		}
	}
}

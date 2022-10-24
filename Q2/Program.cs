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
			int start = 2;
			int end = 1000;

			for (int i = start; i <= end; i++)
			{
				int m = 0;
				for(int k =2; k <=Math.Sqrt(i); k++)
				{
					if (i % k == 0)
					{
						m++;
						break;
					}
				}
				if (m == 0)
				{
					Console.WriteLine(i);
				}
			} 
		}
	}
}

using System;
namespace RoadTrafficDataAnalysis
{
	public class Searching
	{
		public Searching()
		{
		}

		public void TenthIndex(int[] roadArray)
		{
			int i = 0;
			foreach (var item in roadArray)
			{
				i++;
				if (i ==10)
				{
					Console.WriteLine(item);
				}

			}
		}
		public void SearchValue(int value, int[] roadArray)
		{
			int i = -1;
			foreach (var item in roadArray)
			{
				i++;
				if (item == value)
				{
					Console.WriteLine($"{value} at index: {i} ");
				}
			}
		}
	}
}


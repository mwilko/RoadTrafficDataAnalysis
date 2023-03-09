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
			//method which itterates through a given array till the tenth
			//index and outputs it to the user
			int i = 0;
			foreach (var item in roadArray)
			{
				i++;
				if (i == 10)
				{
					Console.WriteLine(item);
				}

			}
		}
		public void SearchValue(int value, int[] roadArray)
		{
			//method which searches an array for the value parameter
			//if found it outputs the value and its index in the array
			int index = 0;
			int valueFound = 0;
			int valueNearest = roadArray[0];
			List<int> nearestValues = new List<int>();


			foreach (int trafficData in roadArray)
			{
				//array indexing starts at 0
                if (trafficData == value)
				{
					valueFound++;
					Console.WriteLine($"{value} at index: {index} ");
				}
                index++;
            }
            //if value is not found in the array, output this error message
            if (valueFound == 0)
            {
                Console.WriteLine($"Error: Value - '{value}', is not found in the selected file. ");

				for (int i = 1; i < roadArray.Length; i++)
				{
					int absDifference = Math.Abs(roadArray[i] - value);
					int closestDifference = Math.Abs(valueNearest - value);

					if (absDifference == closestDifference)
					{
						nearestValues.Add(i);
					}
					else if (absDifference < closestDifference)
					{
						valueNearest = roadArray[i];
						nearestValues.Clear();
						nearestValues.Add(i);
					}
				}
				if (nearestValues.Count == 1)
				{
					Console.WriteLine($"Value nearest to '{value}' is at index '{nearestValues[0]}'");
				}
				else
				{
					Console.WriteLine($"Values nearest to '{value}' are at indexes '{string.Join(", ", nearestValues)}'");
				}
            }




        }
	}
}


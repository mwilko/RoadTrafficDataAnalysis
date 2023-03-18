using System;
namespace RoadTrafficDataAnalysis
{
	public class Searching
	{
		public Searching()
		{
		}

		public void TenthValue(int[] roadArray)
		{
			//method which itterates through a given array till the tenth
			//index and outputs it to the user
			//(i == numberOfValue !valueIndex)
			int i = 0;
			int iterations = 0;
			int steps = 0;

			//step 1 of the tenth value searching algorithm
			Console.WriteLine($"Displaying Tenth Value in the selected array: ");
			steps++;

			foreach (var item in roadArray)
			{
				i++;
				iterations++;
				if (i == 10)
				{
					Console.WriteLine(item);
				}

			}
			Console.WriteLine($"Iterations made '{iterations}', Steps done '{steps}': ");
		}

        public void FifiethValue(int[] roadArray)
        {
            //method which itterates through a given array till the tenth
            //index and outputs it to the user
            //(i == numberOfValue !valueIndex)
            int i = 0;
            int iterations = 0;
            int steps = 0;

            //step 1 of the tenth value searching algorithm
            Console.WriteLine($"Displaying Tenth Value in the selected array: ");
            steps++;

            foreach (var item in roadArray)
            {
                i++;
				iterations++;
                if (i == 50)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine($"Iterations made '{iterations}', Steps done '{steps}': ");
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
					Console.WriteLine($"{value} at index: {index} (Arrays start at 0) ");
				}
                index++;
            }
            //if value is not found in the array, output this error message
            if (valueFound == 0)
            {
                Console.WriteLine($"Error: Value - '{value}', is not found in the selected file. ");

				//changed i to 0 from 1 since index 0 in the list/array would not be found
				for (int i = 0; i < roadArray.Length; i++)
				{
					int absoluteDifference = Math.Abs(roadArray[i] - value);
					int closestDifference = Math.Abs(valueNearest - value);

					if (absoluteDifference == closestDifference)
					{
						nearestValues.Add(i);
					}
					else if (absoluteDifference < closestDifference)
					{
						valueNearest = roadArray[i];
						nearestValues.Clear();
						nearestValues.Add(i);
					}
				}
				if (nearestValues.Count == 1)
				{
                    Console.WriteLine($"Value nearest to '{value}' is at index " +
						$"'{nearestValues[0]}' with a value of '{roadArray[nearestValues[0]]}'");
                }
                else
				{
					//altering the select method of narestValues to output the index value and position when called upon (in the next Console.WriteLine)
                    string nearestValuesString = string.Join(", ", nearestValues.Select(index => $"'{roadArray[index]}' at index '{index}'"));
                    Console.WriteLine($"Values nearest to '{value}' are at indexes {nearestValuesString}");
                }
            }




        }
	}
}


using System;
using System.IO;

namespace RoadTrafficDataAnalysis
{
    //class RTDA256 (derived class), inherits from class Input (base class)
	public class RTDA256 : Input
	{
		public RTDA256()
		{
		}

		public void DataAnalysis()
		{
            //-----------------------------------------------------------------
            //Read files 'Road_1_256.txt','Road_2_256.txt','Road_3_256.txt'
            //into individual arrays
            //-----------------------------------------------------------------
            string road1_256 = "Road_1_256.txt";
            string road1_256Text = File.ReadAllText(road1_256);
            int[] road1_256Array = road1_256Text.Split('\n').Select(int.Parse).ToArray();

            string road2_256 = "Road_2_256.txt";
            string road2_256Text = File.ReadAllText(road2_256);
            int[] road2_256Array = road2_256Text.Split('\n').Select(int.Parse).ToArray();

            string road3_256 = "Road_1_256.txt";
            string road3_256Text = File.ReadAllText(road3_256);
            int[] road3_256Array = road3_256Text.Split('\n').Select(int.Parse).ToArray();

            Searching searching = new Searching();

            //-----------------------------------------------------------------
            //Sort arrays from accending to decending
            //and display 10th index of the array
            //-----------------------------------------------------------------
            Array.Sort(road1_256Array);
            Array.Reverse(road1_256Array);
            Console.WriteLine("Searching for 10th value in Road 1 256 Array...");
            searching.TenthValue(road1_256Array);

            //foreach to check the file indexes
            //foreach (var item in road1_256Array)
            //{
            //    Console.WriteLine(item);
            //}

            Array.Sort(road2_256Array);
            Array.Reverse(road2_256Array);
            Console.WriteLine("Searching for 10th value in Road 2 256 Array...");
            searching.TenthValue(road2_256Array);

            //foreach to check the file indexes
            //foreach (var item in road2_256Array)
            //{
            //    Console.WriteLine(item);
            //}

            Array.Sort(road3_256Array);
            Array.Reverse(road3_256Array);
            Console.WriteLine("Searching for 10th value in Road 3 256 Array...");
            searching.TenthValue(road3_256Array);

            //foreach to check the file indexes
            //foreach (var item in road3_256Array)
            //{
            //    Console.WriteLine(item);
            //}

            //-----------------------------------------------------------------
            //Search selected array for a user-defined value.
            //Provide index(s) or display error message / if not found display
            //
            //-----------------------------------------------------------------
            bool isValid = false;
            int choice = 0;

            //validation for file choice
            do
            {
                Console.WriteLine("Which array would you like to search?" +
                    " Road_1_256 [1], Road_2_256 [2], Road_3_256 [3]:  ");
                choice = GetInputAndTypeValidate(choice);
                isValid = ValidateRange(choice, 1, 3);
            } while (!isValid);

            //validation and loop for the user-defined
            //value to be searched in the array
            int value = 0;
            Console.WriteLine("What value would you like to search for? ");
            value = GetInputAndTypeValidate(value);
            if (choice == 1)
            {
                searching.SearchValue(value, road1_256Array);
            }
            else if (choice == 2)
            {
                searching.SearchValue(value, road2_256Array);
            }
            else if (choice == 3)
            {
                searching.SearchValue(value, road3_256Array);
            }
            else
            {
                Console.WriteLine("Unknown Error: Cant search value in a file");
            }

            //-----------------------------------------------------------------
            //Merging Road_1_256 and Road_3_256 into one text file and then
            //repeating taks 2-4
            //-----------------------------------------------------------------
            string txtFile = "Road1+3_256.txt";

            //merging road 1 and road 2 text files with one and other
            using (StreamWriter w = File.CreateText(txtFile))
            {
                //adding all road1_256 values to text file
                foreach (var item in road1_256Array)
                {
                    w.WriteLine(item);
                }
                //adding all road3_256 values to text file
                foreach (var item in road3_256Array)
                {
                    w.WriteLine(item);
                }
            }

            //reading all text from merged file and writing to string variable
            string road1And3MergeText = File.ReadAllText(txtFile);

            //implementing SteamWriter created error about empty strings not being able to join int array
            //fixed with added where and select methods & validation
            int[] road1And3MergeArray = road1And3MergeText.Split('\n')
                .Where(line => !string.IsNullOrWhiteSpace(line))//ensures no empty/null values
                .Select(line =>
                {
                    int value;
                    if (int.TryParse(line, out value))
                    {
                        return value;
                    }
                    else
                    {
                        //if input is not an integer value or empty space
                        Console.WriteLine($"Could not parse line '{line}' to an integer.");
                        return 0;
                    }
                })
                .ToArray();

            //foreach (var item in road1And3MergeArray)
            //{
            //    Console.WriteLine(item);
            //}

            Array.Sort(road1And3MergeArray);
            Array.Reverse(road1And3MergeArray);
            Console.WriteLine("Searching for 10th value in Road 1+3 merged Array...");
            searching.TenthValue(road1And3MergeArray);

            //validation and loop for the user-defined
            //value to be searched in the array
            int mergedValue = 0;
            Console.WriteLine("What value would you like to search" +
                " for in the Road 1 and Road 3 256 merged file? ");
            mergedValue = GetInputAndTypeValidate(mergedValue);
            //seaching for given value in merged array
            searching.SearchValue(mergedValue, road1And3MergeArray);

        }
    }
}


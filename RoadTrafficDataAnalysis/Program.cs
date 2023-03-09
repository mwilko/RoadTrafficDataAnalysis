using System;
using System.IO;
using System.Linq;

namespace RoadTrafficDataAnalysis
{
    class Program
    {
        static void Main(string[] args)
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
            Input input = new Input();
            RangeValidation rangeValidation = new RangeValidation();

            //-----------------------------------------------------------------
            //Sort arrays from accending to decending
            //and display 10th index of the array
            //-----------------------------------------------------------------
            Array.Sort(road1_256Array);
            Array.Reverse(road1_256Array);
            searching.TenthIndex(road1_256Array);

            //foreach to check the file indexes
            foreach (var item in road1_256Array)
            {
                Console.WriteLine(item);
            }

            Array.Sort(road2_256Array);
            Array.Reverse(road2_256Array);
            searching.TenthIndex(road2_256Array);

            //foreach to check the file indexes
            //foreach (var item in road2_256Array)
            //{
            //    Console.WriteLine(item);
            //}

            Array.Sort(road3_256Array);
            Array.Reverse(road3_256Array);
            searching.TenthIndex(road3_256Array);

            //foreach to check the file indexes
            //foreach (var item in road3_256Array)
            //{
            //    Console.WriteLine(item);
            //}

            //-----------------------------------------------------------------
            //Search selected array for a user-defined value.
            //Provide index(s) or display error message
            //-----------------------------------------------------------------
            bool isValid = false;
            int choice = 0;

            //validation for file choice
            do
            {
                Console.WriteLine("Which array would you like to search?" +
                    " Road_1_256 [1], Road_2_256 [2], Road_3_256 [3]:  ");
                choice = input.GetInputAndTypeValidate(choice);
                isValid = rangeValidation.ValidateRange(choice, 1, 3);
            } while (!isValid);

            //validation and loop for the user-defined
            //value to be searched in the array
            int value = 0;
            Console.WriteLine("What value would you like to search for? ");
            value = input.GetInputAndTypeValidate(value);
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
        }
    }
}
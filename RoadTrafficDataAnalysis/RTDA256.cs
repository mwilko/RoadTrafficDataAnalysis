﻿using System;
using System.IO;

namespace RoadTrafficDataAnalysis
{
    //class RTDA256 (derived class), inherits from class Input (base class)
	public class RTDA256 : Sorting
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
            int[] road1_256ArrayAscending = road1_256Text.Split('\n').Select(int.Parse).ToArray();

            string road2_256 = "Road_2_256.txt";
            string road2_256Text = File.ReadAllText(road2_256);
            int[] road2_256Array = road2_256Text.Split('\n').Select(int.Parse).ToArray();
            int[] road2_256ArrayAscending = road2_256Text.Split('\n').Select(int.Parse).ToArray();


            string road3_256 = "Road_1_256.txt";
            string road3_256Text = File.ReadAllText(road3_256);
            int[] road3_256Array = road3_256Text.Split('\n').Select(int.Parse).ToArray();
            int[] road3_256ArrayAscending = road3_256Text.Split('\n').Select(int.Parse).ToArray();


            Searching searching = new Searching();

            //-----------------------------------------------------------------
            //Sort arrays from accending to decending
            //and display 10th index of the array
            //-----------------------------------------------------------------
            bool isValid = false;
            int choice = 0;

            //validation for file choice
            do
            {
                Console.WriteLine("What Sorting Algorithm would you like to sort all files as?" +
                    " [1] Bubble Sort, [2] Merge Sort [3] Quick Sort [4] Selection Sort: ");
                choice = GetInputAndTypeValidate(choice);
                isValid = ValidateRange(choice, 1, 4);
            } while (!isValid);

            if (choice == 1)//bubble sort
            {
                //ascending to desending ordered arrays
                BubbleSort(road1_256Array, "Road_1_256 Array");
                BubbleSort(road2_256Array, "Road_2_256 Array");
                BubbleSort(road3_256Array, "Road_3_256 Array");
                Console.WriteLine("\n");
                //desending to ascending ordered arrays
                BubbleSort(road1_256ArrayAscending, "Road_1_256 Array (Reverse not implemented)");
                ReverseArray(road1_256ArrayAscending, "Road_1_256 Array (Reverse implemented)");
                BubbleSort(road2_256ArrayAscending, "Road_2_256 Array (Reverse not implemented)");
                ReverseArray(road2_256ArrayAscending, "Road_2_256 Array (Reverse implemented)");
                BubbleSort(road3_256ArrayAscending, "Road_3_256 Array (Reverse not implemented)");
                ReverseArray(road3_256ArrayAscending, "Road_3_256 Array (Reverse implemented)");
                Console.WriteLine("\n");

            }
            else if (choice == 2)//merge sort
            {
                //decending to ascending ordered arrays
                MergeSort(road1_256Array, "Road_1_256 Array");
                MergeSort(road2_256Array, "Road_2_256 Array");
                MergeSort(road3_256Array, "Road_3_256 Array");
                Console.WriteLine("\n");
                //ascending to ascending ordered arrays
                MergeSort(road1_256ArrayAscending, "Road_1_256 (Reverse not implemented)");
                ReverseArray(road1_256ArrayAscending, "Road_1_256 Array (Reverse implemented)");
                MergeSort(road2_256ArrayAscending, "Road_2_256 Array (Reverse not implemented)");
                ReverseArray(road2_256ArrayAscending, "Road_2_256 Array (Reverse implemented)");
                MergeSort(road3_256ArrayAscending, "Road_3_256 Array (Reverse not implemented)");
                ReverseArray(road3_256ArrayAscending, "Road_3_256 Array (Reverse implemented)");
                Console.WriteLine("\n");


            }
            else if (choice == 3)//quick sort
            {
                //decending to ascending ordered arrays
                QuickSort(road1_256Array, "Road_1_256 Array");
                QuickSort(road2_256Array, "Road_1_256 Array");
                QuickSort(road3_256Array, "Road_1_256 Array");
                Console.WriteLine("\n");
                //ascending to ascending ordered arrays
                QuickSort(road1_256ArrayAscending, "Road_1_256 Array (Reverse not implemented)");
                ReverseArray(road1_256ArrayAscending, "Road_1_256 Array (Reverse implemented)");
                QuickSort(road2_256ArrayAscending, "Road_2_256 Array (Reverse not implemented)");
                ReverseArray(road2_256ArrayAscending, "Road_2_256 Array (Reverse implemented)");
                QuickSort(road3_256ArrayAscending, "Road_3_256 Array (Reverse not implemented)");
                ReverseArray(road3_256ArrayAscending, "Road_3_256 Array (Reverse implemented)");
                Console.WriteLine("\n");

            }
            else if (choice == 4)
            {
                //decending to ascending ordered arrays
                SelectionSort(road1_256Array, "Road_1_256 Array");
                SelectionSort(road2_256Array, "Road_1_256 Array");
                SelectionSort(road3_256Array, "Road_1_256 Array");
                Console.WriteLine("\n");
                //ascending to ascending ordered arrays
                SelectionSort(road1_256ArrayAscending, "Road_1_256 Array (Reverse not implemented)");
                ReverseArray(road1_256ArrayAscending, "Road_1_256 Array (Reverse implemented)");
                SelectionSort(road2_256ArrayAscending, "Road_2_256 Array (Reverse not implemented)");
                ReverseArray(road2_256ArrayAscending, "Road_2_256 Array (Reverse implemented)");
                SelectionSort(road3_256ArrayAscending, "Road_3_256 Array (Reverse not implemented)");
                ReverseArray(road3_256ArrayAscending, "Road_3_256 Array (Reverse implemented)");
                Console.WriteLine("\n");
            }
            else
            {
                //error message to catch any unknown errors
                Console.WriteLine($"Error (Choice while sorting): Please contact IT support: ");
            }

            Console.WriteLine("Searching for 10th value in Road 1 256 Array (High-Low)...");
            searching.TenthValue(road1_256Array);
            Console.WriteLine("Searching for 10th value in Road 1 256 Array (Low-High)...");
            searching.TenthValue(road1_256ArrayAscending);


            ////foreach to check the file indexes
            //foreach (var item in road1_256Array)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("NEXT ARRAY START");
            //foreach (var item in road1_256ArrayAscending)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Searching for 10th value in Road 2 256 Array (High-Low)...");
            searching.TenthValue(road2_256Array);
            Console.WriteLine("Searching for 10th value in Road 2 256 Array (Low-High)...");

            searching.TenthValue(road2_256ArrayAscending);


            //foreach to check the file indexes
            //foreach (var item in road2_256Array)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Searching for 10th value in Road 3 256 Array (High-Low)...");
            searching.TenthValue(road3_256Array);
            Console.WriteLine("Searching for 10th value in Road 3 256 Array (Low-High)...");

            searching.TenthValue(road3_256ArrayAscending);


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
            isValid = false;
            choice = 0;

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

            int[] road1And3MergeArrayAscending = road1And3MergeText.Split('\n')
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

            isValid = false;
            choice = 0;

            //validation for file choice
            do
            {
                Console.WriteLine("What Sorting Algorithm would you like to sort all files as?" +
                    " [1] Bubble Sort, [2] Merge Sort [3] Quick Sort [4] Selection Sort: ");
                choice = GetInputAndTypeValidate(choice);
                isValid = ValidateRange(choice, 1, 4);
            } while (!isValid);

            if (choice == 1)//bubble sort
            {
                //decending ordered array
                BubbleSort(road1And3MergeArray, "Road_1+3_256 Array");
                //ascending ordered array
                Console.WriteLine("\n");
                BubbleSort(road1And3MergeArrayAscending, "Road_1+3_256 Array (Reverse not implemented)");
                ReverseArray(road1And3MergeArrayAscending, "Road_1+3_256 Array (Reverse implemented)");
                Console.WriteLine("\n");

            }
            else if (choice == 2)//merge sort
            {
                //decending ordered array
                MergeSort(road1And3MergeArray, "Road_1+3_256 Array");
                //ascending ordered array
                Console.WriteLine("\n");
                MergeSort(road1And3MergeArrayAscending, "Road_1+3_256 Array (Reverse not implemented)");
                ReverseArray(road1And3MergeArrayAscending, "Road_1+3_256 Array (Reverse implemented)");
                Console.WriteLine("\n");

            }
            else if (choice == 3)//quick sort
            {
                //decending ordered array
                QuickSort(road1And3MergeArray, "Road_1+3_256 Array");
                //ascending ordered array
                Console.WriteLine("\n");
                QuickSort(road1And3MergeArrayAscending, "Road_1+3_256 Array (Reverse not implemented)");
                ReverseArray(road1And3MergeArrayAscending, "Road_1+3_256 Array (Reverse implemented)");
                Console.WriteLine("\n");

            }
            else if (choice == 4)
            {
                //decending ordered array
                SelectionSort(road1And3MergeArray, "Road_1+3_256 Array");
                //ascending ordered array
                Console.WriteLine("\n");
                SelectionSort(road1And3MergeArrayAscending, "Road_1+3_256 Array (Reverse not implemented)");
                ReverseArray(road1And3MergeArrayAscending, "Road_1+3_256 Array (Reverse implemented)");
                Console.WriteLine("\n");
            }
            else
            {
                //error message to catch any unknown errors
                Console.WriteLine($"Error (Choice while sorting): Please contact IT support: ");
            }

            //foreach (var item in road1And3MergeArray)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("NEXT ARRAY START");
            //foreach (var item in road1And3MergeArrayAscending)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Searching for 10th value in Road 1+3 merged Array...");
            searching.TenthValue(road1And3MergeArray);
            searching.TenthValue(road1And3MergeArrayAscending);

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


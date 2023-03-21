using System;
using System.Collections.Generic;

namespace RoadTrafficDataAnalysis
{
    public class Searching
    {
        public Searching()
        {
        }
        Input input = new Input();

        //binary search implimented for more searches to be used
        //implimented algorithms steps and iterations
        //
        //Reference which assisted in implimenting this binary search:
        //
        //Begin
        //Set beg = 0
        //Set end = n - 1
        //Set mid = (beg + end) / 2
        //while ((beg <= end) and(a[mid] ≠ item)) do
        // if (item<a[mid]) then
        // Set end = mid - 1
        // else
        // Set beg = mid + 1
        // endif
        //Set mid = (beg + end) / 2
        //endwhile
        //Binary search: implementation
        //if (beg > end) then
        // Set loc = -1
        //else
        // Set loc = mid
        //endif
        //End
        //
        //Brown J. (2023) Searching & Sorting – Part 1. Lincoln: University of Lincoln
        //https://learn-eu-central-1-prod-fleet01-xythos.content.blackboardcdn.com/5eec76bac93d5/10243307?X-Blackboard-S3-Bucket=learn-eu-central-1-prod-fleet01-xythos&X-Blackboard-Expiration=1679356800000&X-Blackboard-Signature=B7OVunfnsz1hfXB4XkaO0V94Ty0PwqAv6cgsMG0BF1E%3D&X-Blackboard-Client-Id=307403&X-Blackboard-S3-Region=eu-central-1&response-cache-control=private%2C%20max-age%3D21600&response-content-disposition=inline%3B%20filename%2A%3DUTF-8%27%27CMP1124M_Lecture_5_Searching%2526Sorting1.pdf&response-content-type=application%2Fpdf&X-Amz-Security-Token=IQoJb3JpZ2luX2VjELP%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaDGV1LWNlbnRyYWwtMSJIMEYCIQDMTQoNKRI3J5AhmsopEka7G%2FukmZ46GpREPJl9GQQIygIhAO7ufKtE7%2BCRnuWORE6S5yD26GW9zwDHpZijvKYROe7sKr4FCHwQAxoMNjM1NTY3OTI0MTgzIgz2zui1vcoktl6rmWwqmwVsEhMxQoDZBhyQ%2BrBiQ6mp52L7%2ByMTUE6FGD2XUNyX5avdnm7W4kXXjxgW1%2FKs%2F41Rd5Ic2Ww81Xo65iIIGBMXeRR%2Foo1FqZUtplrQfKN3CCk866F5oEYtf7vhnzmQAzysypvzQAEkoX1VaUaI5Dr6eK0%2FnGK4NnCYWa7ZjdqCakUZfTOkkJixCukmR9UoskBMDceKEbL3rAOB%2FheRLVGu1OsvO5XJzzIIcWHSiwXT04SW8X7XmFwWdd6LnZT9V5FC7H3uiCcaehtSPXA%2FaEadk2VUtSfhWthpfV3ZdhpC4LLg9pNSJUDFsWuanzIYOMMJ0Nlct6eWQJG5bSL7wC%2F9Nt8dbhhL%2BoOWvBVO3lOifLSzfso8IFWiiejeQ4E%2Fovxe5sATQvv2Skz%2FHUq2HZtc89zDBGjpMmwoDhN85z%2BkjKtBXwTKUrxsESRNYImxDIr2bWVQJPnkQbp2%2FN44LpVcBpYyMPpP%2FryC2yjio%2Bzfnz%2Fx9rGxWk9Hfv65TKwy53FD4FL7QmpsTbkin4ma2BQaNAUOf4ufSBQJt%2FU8%2BxiFBKvPC%2B8sWa4Zqs0bRRVCoK1s%2FRcZz%2BoXJhQ%2Bjs8B0lZ30zNI2h2mi1134WndF%2Bb33WKjChbLzwJvO870Lpda0I%2FS%2BDmrkEDhAYCoHpgHHOLvQoHaKbCMRdBRBMDMYvMdenu9pUU57lHVdpY6rt%2BMNwZFcrQRwlNcEzjCgsvYoXm5GoTt3%2BVtsE0jJEnzlWVGa0aFDKWSD2nvvE5UPlN8XJz7KeSQZrJt7Tb%2F9U%2Bjt1gtmefCzUii1Gp%2BlgidU0TqBr6Oihg9k%2FF1nub8jXgW%2FS8DWoWimmvqnviKtVB8vVbm94d4sYoRx2EezQSUMYoXiOrynDVv%2BPvTPaJ9MIbV4qAGOrAByEfhmpArpegr6EmQ6Be3RWWa3f1C8AsPQ1V57MRxVhcisX0ViTv3jdz9A38z1cfwgPMlGdS8%2BS%2BFBTiBcYsKkTV24aAIndApnhO9HTUbwG2vAMEmjAKcEAmzcUbC7BRXCI%2BwoO4eqy5tBwAhtMv%2FPAWG0JDnpQKOHphixzckAD040uItrfAHVNyDjDXeaqhiD7tymjMu1dMBvBjVQvNzl3qt8vwIoxLIAs%2BWles8Mw0%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Date=20230320T180000Z&X-Amz-SignedHeaders=host&X-Amz-Expires=21600&X-Amz-Credential=ASIAZH6WM4PL22A4OHMQ%2F20230320%2Feu-central-1%2Fs3%2Faws4_request&X-Amz-Signature=d38a32e493c2009c2f0d9d5bc5b44a8497424b7a93eca535ea6b875b1e7b3996
        //
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            int iterations = 0;
            int steps = 0;

            steps++;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == target)
                {
                    iterations++;
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    iterations++;
                    left = mid + 1;
                }
                else
                {
                    iterations++;
                    right = mid - 1;
                }
            }

            // If the value is not found, find the nearest value
            int valueNearest = arr[0];
            List<int> nearestValues = new List<int>();

            steps++;
            for (int i = 0; i < arr.Length; i++)
            {
                int absoluteDifference = Math.Abs(arr[i] - target);
                int closestDifference = Math.Abs(valueNearest - target);

                if (absoluteDifference == closestDifference)
                {
                    iterations++;
                    nearestValues.Add(i);
                }
                else if (absoluteDifference < closestDifference)
                {
                    iterations++;
                    valueNearest = arr[i];
                    nearestValues.Clear();
                    nearestValues.Add(i);
                }
            }

            if (nearestValues.Count == 1)
            {
                steps++;
                Console.WriteLine($"Value nearest to '{target}' is at index " +
                    $"'{nearestValues[0]}' with a value of '{arr[nearestValues[0]]}'");
            }
            else
            {
                steps++;
                //altering the select method of nearestValues to output the index value and position when called upon (in the next Console.WriteLine)
                string nearestValuesString = string.Join(", ", nearestValues.Select(index => $"'{arr[index]}' at index '{index}'"));
                Console.WriteLine($"Values nearest to '{target}' are at indexes {nearestValuesString}");
            }
            Console.WriteLine($"Iterations made '{iterations}', Steps done '{steps}' \n ");
            return -1;
        }



        public void TenthValue(int[] roadArray)
        {
            //method which iterates through a given array till the tenth
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
            Console.WriteLine($"Iterations made '{iterations}', Steps done '{steps}': \n");
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
            Console.WriteLine($"Iterations made '{iterations}', Steps done '{steps}': \n");
        }

        public void SearchValue(int value, int[] roadArray)
        {
            {
                //method which searches an array for the value parameter
                //if found it outputs the value and its index in the array
                int index = 0;
                int valueFound = 0;
                int valueNearest = roadArray[0];
                int iterations = 0;
                int steps = 0;
                List<int> nearestValues = new List<int>();

                bool isValid = false;
                int choice = 0;

                //validation for searching algorithm choice
                do
                {
                    Console.WriteLine("Which Searching Algorithm would you like to use? [1] Binary Search, [2] Linear Search:  ");
                    choice = input.GetInputAndTypeValidate(choice);
                    isValid = input.ValidateRange(choice, 1, 2);
                } while (!isValid);

                if (choice == 1) //binary search is chosen
                {
                    //binary search algorithm to look for user input
                    BinarySearch(roadArray, value);                    
                }
                else if (choice == 2)//linear search is chosen
                {
                    steps++;
                    foreach (int trafficData in roadArray)
                    {
                        iterations++;
                        //array indexing starts at 0
                        if (trafficData == value)
                        {
                            valueFound++;
                            Console.WriteLine($"{value} at index: {index} (Arrays start at 0) ");
                        }
                        index++;
                    }
                    //if value is not found in the array, output this error message
                    steps++;
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
                                iterations++;
                                nearestValues.Add(i);
                            }
                            else if (absoluteDifference < closestDifference)
                            {
                                iterations++;
                                valueNearest = roadArray[i];
                                nearestValues.Clear();
                                nearestValues.Add(i);
                            }
                        }
                        if (nearestValues.Count == 1)
                        {
                            steps++;
                            Console.WriteLine($"Value nearest to '{value}' is at index " +
                                $"'{nearestValues[0]}' with a value of '{roadArray[nearestValues[0]]}'");
                        }
                        else
                        {
                            steps++;
                            //altering the select method of narestValues to output the index value and position when called upon (in the next Console.WriteLine)
                            string nearestValuesString = string.Join(", ", nearestValues.Select(index => $"'{roadArray[index]}' at index '{index}'"));
                            Console.WriteLine($"Values nearest to '{value}' are at indexes {nearestValuesString}");
                        }
                    }
                    Console.WriteLine($"Iterations made '{iterations}', Steps done '{steps}' \n ");
                }
            }
        }
    }
}


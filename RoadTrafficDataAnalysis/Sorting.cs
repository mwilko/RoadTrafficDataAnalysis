using System;
namespace RoadTrafficDataAnalysis
{
    public class Sorting : Input
    {
        public Sorting()
        {
        }

        //algorithm to reverse given array
        public void ReverseArray(int[] roadArray, string arrayName)
        {
            int left = 0;
            int right = roadArray.Length - 1;
            int steps = 0; //used to calculate steps in algorithm

            while (left < right)
            {
                int temp = roadArray[left];
                roadArray[left] = roadArray[right];
                roadArray[right] = temp;

                left++;
                right--;
                steps++;
            }
            Console.WriteLine($"Steps while reversing {arrayName}: '{steps}' ");
        }

        //bubble sort algorithm implemented to sort by ascending to desending
        //Referenced:
        //
        //public void bubbleSort(int[] a, int n){
        //for (int i = 0; i<n-1; i++) {
        //for (int j = 0; j<n-1-i; j++){
        //if (a[j + 1] < a[j]) {
        //int temp = a[j];
        //a[j] = a[j + 1];
        //a[j + 1] = temp;
        //}
        //}
        //}
        //}
        //
        //Brown J. (2023) Searching & Sorting – Part 1. Lincoln: University of Lincoln
        //https://learn-eu-central-1-prod-fleet01-xythos.content.blackboardcdn.com/5eec76bac93d5/10243307?X-Blackboard-S3-Bucket=learn-eu-central-1-prod-fleet01-xythos&X-Blackboard-Expiration=1679443200000&X-Blackboard-Signature=75oItvEbDb54hKctVrsSUT%2F3DMDH32CFvNrmCBproqw%3D&X-Blackboard-Client-Id=307403&X-Blackboard-S3-Region=eu-central-1&response-cache-control=private%2C%20max-age%3D21600&response-content-disposition=inline%3B%20filename%2A%3DUTF-8%27%27CMP1124M_Lecture_5_Searching%2526Sorting1.pdf&response-content-type=application%2Fpdf&X-Amz-Security-Token=IQoJb3JpZ2luX2VjEM3%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaDGV1LWNlbnRyYWwtMSJHMEUCIHIt0nHRBJlVgDhQH%2Fnf7JEwYBOkWlZSq8QNb%2BgOs1CiAiEA2OUx19itPPZyj4%2B6TUmJHhA9iQkchpCSJaY7fNiFK74qxwUIlv%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FARADGgw2MzU1Njc5MjQxODMiDH10f%2BUeVOgBknx6xCqbBfczCtmLQzXYfnlovY2Ms5Tv9E4vq2BLr%2F80CyXqy5tBfJMC05UCpQoWfBIhxdqDXmj7XRRPLGSGjYeztsboou1gPftDMPThJl%2BDPi0w7yHLUYB1lX8HQeyJgCS8HWzIgtFN5R1fv6QVK6pYu6KeyfFq0qZRdsOJclCdfvU5y9bkeI372GBIMqBN1KUsSmmAhaKdB2K1i1lKhyj2AvpIGQP4mGTgpsLLqgYqezHpB5c%2Bbk6SHZr7EG79cVeSTG0p2WIPtifLN7pc0W1WhoGfLdkNjOkYyWQ1%2BNPkDGKhNQaOtpyeAGaOnHx2akPEM9UFMVs29ielCLCcbu%2BbUGN8ewRlD6N%2B3H0ymR8618AIb9Bj0Bt1FIFOkS1zNrJhK93GgorjAI1S9xUvc6EpMzqcpyAQtW9jcZ%2Btv%2Flj1RzyEptOrZqazj9YdPoY44Nl1ziYMReLBQjoRGFSfExNcKtM7nEbDzrNSPVgwt7CYKNODm7qu7ThiwSx7gyOGD6YYJujDu7vFo60HBpa4vfQKoBuEOucPdnTqNbtengPozw5FLcSjvYxbt%2BwBNt3GXQ2xwuotVIm42k2J9LcUnCeDHvXDYg6w2MygikEL6F9zwuGQoI6n%2FRrofWEDez7knDdQ2eZ3tLXz4DLS2PvQACCr%2BMFPkJfJaiIE5V8wRMAHPZ7JieuosXZXXql7GMj9aKJIVgoVXBwUVEGhY9p3FZwAweUzhV9O6qXJfJuzm%2FHiUL3dzA9xXsiStzsUVQS01fSJzbwuHDP3wKEDrbaJJMtYWTtTG3kmyYfZZt1VoIQHeddDZd7BR97iAMIuvhs75vvwrBcrXEkFA3D6wefYmuHm6mjj3r9%2BxrhSE6p5tr2a%2Ff6VYsRROfqKyYLoDSHaSww1qrooAY6sQHEX%2BLYgEdQhJDxB5eEOQ8VaHd9D1%2FXFtEskck6%2BsRyTiqYymldqiZ367%2BMa1493uN5F7MkCl1%2FdIXirLjnEV9VvpN6ynagMpCXN7zSOtiFIVKtbR7ty%2F%2FGlimmYzrh5pIMDmYgcoZ%2FMfy4yfONF151xT4%2Bt17k3AnkSMHC3MYHp9GQXwFUOH%2F5vCQIqxU5uDZ1OCPjnjtjBUOxAQX%2Ba%2B%2FzCR1JG50%2FPxCVAQzQhffygdM%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Date=20230321T180000Z&X-Amz-SignedHeaders=host&X-Amz-Expires=21600&X-Amz-Credential=ASIAZH6WM4PL32GCQA5Z%2F20230321%2Feu-central-1%2Fs3%2Faws4_request&X-Amz-Signature=5e14a657e86d046669f57a16f54b5a2444c45d3f3d703dc1211eba8c64d80cfb
        //

        //bubble sort algorithm
        public void BubbleSort(int[] roadArray, string arrayName)
        {
            int temp;
            int steps = 0; //used to calculate steps in algorithm
            for (int i = 0; i < roadArray.Length - 1; i++)
            {
                for (int j = 0; j < roadArray.Length - i - 1; j++)
                {
                    if (roadArray[j] < roadArray[j + 1])
                    {
                        temp = roadArray[j];
                        roadArray[j] = roadArray[j + 1];
                        roadArray[j + 1] = temp;
                        steps++;
                    }
                    steps++;
                }
            }
            Console.WriteLine($"Steps while Bubble Sorting {arrayName}: '{steps}' ");
        }

        //mergesort method and merge method used for the Merge Sort algorithm
        //Referenced:
        //
        //void MergeSort(int []v){
        //if (v.size() > 1) {
        //int n1 = v.size() / 2;
        //int n2 = v.size() - n1;
        //int[] left = Copy(v, 0, n1);
        //int[] right = Copy(v, n1, n2);
        //MergeSort(left);
        //MergeSort(right);
        //Merge(v, left, right);
        //}
        //}
        //
        //Brown J. (2023) Searching & Sorting – Part 2. Lincoln: University of Lincoln
        //https://learn-eu-central-1-prod-fleet01-xythos.content.blackboardcdn.com/5eec76bac93d5/10294062?X-Blackboard-S3-Bucket=learn-eu-central-1-prod-fleet01-xythos&X-Blackboard-Expiration=1679443200000&X-Blackboard-Signature=wjjY7IMsQKR4IC41TvkQOQUk9%2FHJUKbOJ%2FS3vLHwvQU%3D&X-Blackboard-Client-Id=307403&X-Blackboard-S3-Region=eu-central-1&response-cache-control=private%2C%20max-age%3D21600&response-content-disposition=inline%3B%20filename%2A%3DUTF-8%27%27CMP1124M_Lecture6_Searching%2526Sorting2.pdf&response-content-type=application%2Fpdf&X-Amz-Security-Token=IQoJb3JpZ2luX2VjEMz%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaDGV1LWNlbnRyYWwtMSJHMEUCIQCEn49iDgaZimicC189%2BqYNGu6ScnEQ2TTSy1YE7DsiwQIgcyfW2pwJr6VZUjnAeeFA17pNuGlzdAmv4eDbzgW%2BehgqxwUIlf%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FARADGgw2MzU1Njc5MjQxODMiDIe03m6NlyxhtJ4MgiqbBeQGg8GUfcjCDJ%2B5RoDVnaVDLIMgx0dDJYWMWsKW%2Fn7uxv9E2vVlzat9Wnxu44EatZP%2FqY9vuyPXNsjcfF0Nyp%2Bppfbult7E0WpaC8Phj25wXTR0BKpyvHP1JQb7IgFxMAQs%2BGTsc6VNrnDu1ZvD0h9cLtRMnn%2B6Q7aS%2FXGhbE%2FNv3FbdKULWrG0xmURtSBctH3pCNjj18j1ixl1TubzIhhxfmYqNl%2F8RUzyuTMTK4xFNH%2BfhIUqngGeO8olMJQIRZX2jzHQoJfbY7JMUgAg5ii0KACmzzzPmoZiMlAHfJ7wduEqLev4Ao9tS4D4g2TU2EnKuKyY2PQWCRh7lvxmKI%2BgiIOIrztRcpplLtsgrz8js704eWRQUp1ArSWKuFzSTcuXuZj60eDpy6Qa7xhFk8OR3PKwauLT%2FDKHkjmpMXHTOCxqV7DEZzTu7kkVc2X9By1NuylTjxGCgd7TM2dJc3hW2v%2FdBefeVEJDkFiR0TFWL4uyFZfTxiDZT05oryJnIidBBqXp5BIINgpH3pThjkkX7gumuK5rXWyaEAFil%2FBytPlzrw3%2F9fMu8tbCcmgYXdfNJkzh%2Bonm2%2BQubO3qEelxvD4zuXlpjANRQEFBLOGXxl1cGR5x2oj3%2BU6lp2S2z2YpAsWeEsLtwq3GdmIeaWyAuSezP%2B4KQ9%2FoNAtyl34BQrJrovJftmIuEdAIv7jU5ioCmGfeD9pFUI2I2MCEedLKtmuUQJvbhJsdQsJo06o3b8%2FhHkdX0KTB2XMT4na5U74Glsc%2FU8Ry6crJfe0qfbU3QGuhzXuM92j12i61vNidS7q6OQbrbYDZTkZDRwuCHrREamgMp8VRgS%2FTgjDLXYSllWJDH2Q%2FXZvY3z5Qv8vVoznJPkhLM5Q8ri8w2YzooAY6sQGIxK4gGhCraWvNyfdrd%2Ff0zAaykTuDBcugtgufdWfvAjh19TwGstYL9X6%2FzfyI%2B2qdDd1lUdlojUFg%2FWIHRNhJbUCcSrdw6jf3pwbYKcC4DDFVRAzBJWLMY%2BWcKfqZUIg6irnJyWn%2Bbwh%2B8J%2B6KorpIDzlMarHNh8AYC6pxS3t3U%2FBYEGqnwof3npxaO%2BbV4INfyKOhTyf88Cb8S9KiAevzFu3g6s8TKBBzp3fJphPwxE%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Date=20230321T180000Z&X-Amz-SignedHeaders=host&X-Amz-Expires=21600&X-Amz-Credential=ASIAZH6WM4PLY36J6BWJ%2F20230321%2Feu-central-1%2Fs3%2Faws4_request&X-Amz-Signature=cdb433769ffd2f305bef16fe034ad363604bf42b340fd8ba7f4bfcaa84b51482
        //

        //merge sort algorithm
        //steps referenced so it is not overridden or set to 0 when initiated
        public void MergeSort(int[] roadArray, string arrayName)
        {
            int steps = 0;
            Sort(roadArray, 0, roadArray.Length - 1, ref steps);
            Console.WriteLine($"Steps while Merge Sorting {arrayName}: '{steps}' ");

        }

        private void Sort(int[] roadArray, int left, int right, ref int steps)
        {
            if (left >= right)
            {
                return;
            }

            int mid = left + (right - left) / 2;
            Sort(roadArray, left, mid, ref steps);
            Sort(roadArray, mid + 1, right, ref steps);
            Merge(roadArray, left, mid, right, ref steps);
        }

        private void Merge(int[] roadArray, int left, int mid, int right, ref int steps)
        {
            int[] temp = new int[roadArray.Length];
            for (int i = left; i <= right; i++)
            {
                temp[i] = roadArray[i];
            }

            int leftIndex = left;
            int rightIndex = mid + 1;
            int currentIndex = left;

            while (leftIndex <= mid && rightIndex <= right)
            {
                if (temp[leftIndex] <= temp[rightIndex])
                {
                    roadArray[currentIndex] = temp[leftIndex];
                    leftIndex++;
                }
                else
                {
                    roadArray[currentIndex] = temp[rightIndex];
                    rightIndex++;
                }
                currentIndex++;
                steps++;
            }

            while (leftIndex <= mid)
            {
                roadArray[currentIndex] = temp[leftIndex];
                leftIndex++;
                currentIndex++;
                steps++;
            }
        }

        //quick sort algorithm
        public void QuickSort(int[] roadArray, string arrayName)
        {
            int steps = 0; //added to track steps of algorithm
            QuickSort(roadArray, 0, roadArray.Length - 1, ref steps);
            Console.WriteLine($"Steps while Bubble Sorting {arrayName}: '{steps}' ");
        }

        private void QuickSort(int[] roadArray, int leftIndex, int rightIndex, ref int steps)
        {
            if (leftIndex >= rightIndex)
            {
                return;
            }

            int i = leftIndex;
            int j = rightIndex;
            int pivot = roadArray[(leftIndex + rightIndex) / 2];

            while (i <= j)
            {
                while (roadArray[i] < pivot)
                {
                    i++;
                    steps++;
                }

                while (roadArray[j] > pivot)
                {
                    j--;
                    steps++;
                }

                if (i <= j)
                {
                    int temp = roadArray[i];
                    roadArray[i] = roadArray[j];
                    roadArray[j] = temp;
                    i++;
                    j--;
                }
            }

            QuickSort(roadArray, leftIndex, j, ref steps);
            QuickSort(roadArray, i, rightIndex, ref steps);
        }

        public static void SelectionSort(int[] roadArray, string arrayName)
        {
            int steps = 0;
            for (var i = 0; i < roadArray.Length; i++)
            {
                steps++;
                var min = i;
                for (var j = i + 1; j < roadArray.Length; j++)
                {
                    steps++;
                    if (roadArray[min] > roadArray[j])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var lowerValue = roadArray[min];
                    roadArray[min] = roadArray[i];
                    roadArray[i] = lowerValue;
                }
            }
            Console.WriteLine($"Steps while Selection Sorting {arrayName}: '{steps}' ");
        }
    }
}


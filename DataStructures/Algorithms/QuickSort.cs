using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Algorithms
{
    class QuickSort
    {
        public static void Do()
        {
            int[] numbers = new int[] { 20, 21, 30, 12, 11, 10, 60, 45 };
            Sort(numbers, 0, numbers.Length - 1);
        }
        private static void Sort(int[] numbers, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(numbers, left, right);
                if (pivot > 1)
                    Sort(numbers, left, pivot - 1);
                if (pivot + 1 < right)
                    Sort(numbers, pivot + 1, right);

            }
        }
        private static int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;
                while (numbers[right] > pivot)
                    right--;
                if (left < right)
                {
                    int temp = numbers[left];
                    numbers[left] = numbers[right];
                    numbers[right] = temp;
                }
                else
                    return right;
            }
        }
        private static void Print(int[] numbers)
        {
            foreach (int num in numbers)
                Console.Write(num + " ");
        }
    }
}

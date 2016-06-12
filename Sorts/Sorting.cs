using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Sorting
    {
        //Swap without temp
        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        //Swap with using temporary variable
        public static void Swap2(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = a;
        }

        //Bubble Sort                   [https://en.wikipedia.org/wiki/Bubble_sort]
        //Worst performance:            O(n^2)
        //Best performance:             O(n)
        //Avarage performance:          O(n^2)
        //Worst case space complexity:  O(1)
        public static void BubbleSort(ref int[] array)
        {
            int N = array.Length;
            for (int i = 0; i < N-1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < N - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapped = true;
                    }
                }
                if(!swapped)
                {
                    break;
                }
            }
        }


        //Shaker Sort                   [https://en.wikipedia.org/wiki/Cocktail_shaker_sort]
        //Worst performance:            O(n^2)
        //best performance:             O(n)
        //Avarage performance:          O(n^2)
        //Worst case space complexity:  O(1)
        public static void ShakerSort(ref int[] array)
        {
            int left = 0,
                right = array.Length - 1;

            while (left <= right)
            {
                for (int i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    if (array[i-1] > array[i])
                    {
                        Swap(ref array[i-1], ref array[i]);
                    }
                }
                left++;
            }


        }


        //Insertion sort                [https://en.wikipedia.org/wiki/Insertion_sort]
        //Worst performance:            О(n^2) comparisons, swaps
        //Best performance:             O(n) comparisons, O(1) swaps
        //Avarage performance:          О(n^2) comparisons, swaps
        //Worst case space complexity:  О(n) total, O(1) auxiliary
        public static void InsertionSort(ref int[] array)
        {
            int N = array.Length;

            for (int i = 1; i < N; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }


        //Merge sort                    [https://en.wikipedia.org/wiki/Merge_sort]
        //Worst performance:            О(n log n)
        //Best performance:             O(n log n) typical, O(n) natural variant
        //Avarage performance:          O(n log n)
        //Worst case space complexity:  О(n) total, O(n) auxiliary
        public static void MergeSort(ref int[] array)
        {
            //TODO: Merge sort
        }

        //TODO: Quick Sort Description
        public static void QuickSort()
        {
            //TODO: Quick Sort
        }

    }
}

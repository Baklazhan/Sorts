using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sorts
{
    class Program
    {
        const int MAXN = 100;
        const int RANDMIN = 0;
        const int RANDMAX = 1000;

        static void Main(string[] args)
        {
            //Swap Check
            bool swapTest = Swap_Test();
            Console.WriteLine("Swap test finished with result: \t\t{0}", swapTest);
            Console.WriteLine("\n");

            //Swap2 Check
            bool swap2Test = Swap2_Test();
            Console.WriteLine("Swap2 test finished with result: \t\t{0}", swap2Test);
            Console.WriteLine("\n");

            //BubbleSort check
            bool bubbleSortTest = BubbleSort_Test();
            Console.WriteLine("BubbleSort test finished with result: \t\t{0}", bubbleSortTest);
            Console.WriteLine("\n");

            //ShakerSort check
            bool shakerSortTest = ShakerSort_Test();
            Console.WriteLine("ShakerSort test finished with result: \t\t{0}", shakerSortTest);
            Console.WriteLine("\n");

            //ShakerSort check
            bool insertionSortTest = InsertionSort_Test();
            Console.WriteLine("InsertionSort test finished with result: \t{0}", insertionSortTest);
            Console.WriteLine("\n");

            //MergeSort check
            bool mergeSortTest = MergeSort_Test();
            Console.WriteLine("MergeSort test finished with result: \t\t{0}", mergeSortTest);
            Console.WriteLine("\n");


            Console.Read();
            Console.Read();

        }

        public static bool Swap_Test()
        {
            int a = 5;
            int b = 7;
            int old_a = a;
            int old_b = b;

            Sorting.Swap(ref a, ref b);
            
            if (old_a == b && old_b == a)
            {
                return true;
            }
            return false;

        }

        public static bool Swap2_Test()
        {
            int a = 5;
            int b = 7;
            int old_a = a;
            int old_b = b;

            Sorting.Swap2(ref a, ref b);

            if (old_a == b && old_b == a)
            {
                return true;
            }
            return false;

        }

        public static bool BubbleSort_Test()
        {
            Random rand = new Random();
            int[] array = new int[MAXN];

            for (int i = 0; i < MAXN; i++)
            {
                array[i] = rand.Next(RANDMIN, RANDMAX);
                //Uncomment this to see UNSORTED ARRAY
                //Console.Write("{0} ", array[i]);
            }

            Sorting.BubbleSort(ref array);

            for (int i = 0; i < MAXN-1; i++)
            {
                //Uncomment this to see SORTED ARRAY
                //Console.Write("{0} ", array[i]);
                if (array[i] > array[i+1])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool ShakerSort_Test()
        {
            Random rand = new Random();
            int[] array = new int[MAXN];

            for (int i = 0; i < MAXN; i++)
            {
                array[i] = rand.Next(RANDMIN, RANDMAX);
                //Uncomment this to see UNSORTED ARRAY
                //Console.Write("{0} ", array[i]);
            }

            Sorting.ShakerSort(ref array);

            for (int i = 0; i < MAXN - 1; i++)
            {
                //Uncomment this to see SORTED ARRAY
                //Console.Write("{0} ", array[i]);
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool InsertionSort_Test()
        {
            Random rand = new Random();
            int[] array = new int[MAXN];

            for (int i = 0; i < MAXN; i++)
            { 
                array[i] = rand.Next(RANDMIN, RANDMAX);
                //Uncomment this to see UNSORTED ARRAY
                //Console.Write("{0} ", array[i]);
            }

            //Console.WriteLine("\n");
            Sorting.InsertionSort(ref array);

            for (int i = 0; i < MAXN - 1; i++)
            {
                //Uncomment this to see SORTED ARRAY
                //Console.Write("{0} ", array[i]);
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            //Console.WriteLine("\n");
            return true;
        }

        public static bool MergeSort_Test()
        {
            Random rand = new Random();
            int[] array = new int[MAXN];

            for (int i = 0; i < MAXN; i++)
            {
                array[i] = rand.Next(RANDMIN, RANDMAX);
                //Uncomment this to see UNSORTED ARRAY
                //Console.Write("{0} ", array[i]);
            }

            //Console.WriteLine("\n");
            Sorting.MergeSort(ref array);

            for (int i = 0; i < MAXN - 1; i++)
            {
                //Uncomment this to see SORTED ARRAY
                //Console.Write("{0} ", array[i]);
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            //Console.WriteLine("\n");
            return true;
        }

    }
}

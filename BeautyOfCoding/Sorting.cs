using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BeautyOfCoding
{
    public static class Sorting
    {
        #region Quick Sort
        public static void QuickSortMain()
        {
            int[] X = { 6, 2, 7, 11, 32, 15, 9, 0, 3, 11, 8, 7, 2, 6 };
            Stopwatch sw = new Stopwatch();
            sw.Start();
            QuickSortDQ(X, 0, X.Length - 1);
            sw.Stop();
            foreach (var item in X)
            {
                Console.WriteLine(item + ",");
            }
            Console.WriteLine("Time Elaspe: {0}", sw.ElapsedMilliseconds * 1.000000);
            Console.ReadKey();

        }

        private static void QuickSortDQ(int[] unsorted, int low, int high)
        {
            int loc = 0;
            if (low < high)
            {
                loc = Partation(unsorted, low, high);
                QuickSortDQ(unsorted, low, loc - 1);
                QuickSortDQ(unsorted, loc + 1, high);
            }
        }
        private static int Partation(int[] unsorted, int low, int high)
        {               
            int pivot = unsorted[low];
            while (low < high)
            {
                while (low < high && unsorted[high] > pivot)
                {
                    high--;
                }
                if (low < high)
                {
                    unsorted[low] = unsorted[high];
                    low++;
                }

                while (low < high && unsorted[low] <= pivot)
                {
                    low++;
                }
                if (low < high)
                {
                    unsorted[high] = unsorted[low];
                    high--;
                }
            }
            unsorted[low] = pivot;

            return low;
        }
        #endregion  

    }
}

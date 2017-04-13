using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDD
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Tests_qsort.TestIn3());
            Console.WriteLine(Tests_qsort.TestInSameNumbers());
            Console.WriteLine(Tests_qsort.TestInEmptyArray());
            Console.WriteLine(Tests_qsort.TestIn1000());
            // Summon the Devil 
            // Console.WriteLine(Tests_qsort.StressTest());
            Console.ReadKey();
        }

        public static void qsort(ref int[] arr, int low, int high)
        {
            if (low > high)
                return;
            int i = low;
            int j = high;
            int median = Median(arr[low], arr[high], arr[(low + high) / 2]);
            while (i < j)
            {
                while (i < j && arr[i] <= median)
                    i++;
                while (j >= i && arr[j] > median)
                    j--;
                if (i < j)
                {
                    arr[i] += arr[j];
                    arr[j] = arr[i] - arr[j];
                    arr[i] = arr[i] - arr[j];
                }
            }
            if (i - low > 0) 
                qsort(ref arr, low, i - 1);
            if (high - i > 1)
                qsort(ref arr, i, high);
            return;
        }

        public static int Median(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }
    }
}

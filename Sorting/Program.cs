using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 5, 4, 7, 1, 3 ,6, 2 };
            CountSort countSort = new CountSort();
            countSort.Sort(arr , 8);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}

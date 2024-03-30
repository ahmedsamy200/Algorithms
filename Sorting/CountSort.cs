using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class CountSort
    {
        public void Sort(int[] arr , int max)
        {
            int[] counts = new int[max + 1];
            foreach (var item in arr)
            {
                counts[item]++;
            }
            int k = 0;
            for (int i = 0; i < counts.Length; i++)
            {
                for (int j = 0; j < counts[i]; j++)
                {
                    arr[k++] = i;
                }
            }
        }
    }
}

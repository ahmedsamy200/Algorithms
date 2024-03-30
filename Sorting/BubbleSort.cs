using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort
    {
   
        public void Sort(int[] arr)
        {
            bool isSorted;
            for (int i = 0; i < arr.Length; i++)
            {
                isSorted = true;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        Swap(arr ,j, j + 1);
                        isSorted = false;
                    }
                }
                if (isSorted) return;
            }
        }

        public void Swap(int[] arr, int first , int second)
        {
            // (arr[first], arr[second]) = (arr[second], arr[first]);
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}

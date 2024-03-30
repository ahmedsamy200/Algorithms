using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSort
    {
        public void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        public void Sort(int[] arr , int start , int end)
        {
            if (start >= end) return;
            int pivot = Partition(arr , start , end);
            Sort(arr, start, pivot - 1);
            Sort(arr, pivot + 1, end);
        }

        private int Partition(int[] arr , int start , int end)
        {
            int pivot = arr[end];
            int boundry = start -1;
            for (int i = start; i <= end; i++)
            {
                if(arr[i] <= pivot)
                {
                    Swap(arr, i, ++boundry);
                }
            }
            return boundry;
        }

        public void Swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}

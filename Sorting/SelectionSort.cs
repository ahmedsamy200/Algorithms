using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int smallest_Index = GetSmallest(arr , i);
                Swap(arr, i, smallest_Index);
              
            }
        }

        public int GetSmallest(int[] arr , int index)
        {
            int smallest = index;
            for (int i = index; i < arr.Length; i++)
            {
                if (arr[i] < arr[smallest]) smallest = i;
            }
            return smallest;
        }

        public void Swap(int[] arr, int first, int second)
        {          
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}

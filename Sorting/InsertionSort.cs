using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class InsertionSort
    {
        public void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }


        //public void Sort(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < i; j++)
        //        {
        //            int current = arr[i];
        //            if(arr[j] > current)
        //            {
        //                arr[i] = arr[j];
        //                arr[j] = current;
        //            }
        //        }
        //    }
        //}


    }
}

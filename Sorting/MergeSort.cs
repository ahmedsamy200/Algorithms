using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeSort
    {
        public void Sort(int[] arr)
        {
            if (arr.Length < 2) return;

            int middle = arr.Length / 2;
            int[] left = new int[middle];
            for (int i = 0; i < middle; i++)
            {
                left[i] = arr[i];
            }

            int[] right = new int[arr.Length - middle];
            for (int i = middle; i < arr.Length; i++)
            {
                left[i - middle] = arr[i];
            }

            Sort(left);
            Sort(right);
            Merge(left, right, arr);
        }

        private void Merge(int[] left , int[] right , int[] result)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j]) result[k++] = left[i];
                else result[k++] = right[j++];                
            }

            while (i < left.Length)
            {
                result[k++] = left[i++];
            }

            while (j < right.Length)
            {
                result[k++] = right[j++];
            }

        }
    }
}

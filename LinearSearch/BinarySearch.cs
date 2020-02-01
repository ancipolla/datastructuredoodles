using System;
using System.Collections.Generic;
using System.Text;

namespace LinearSearch
{
   public class BinarySearch
    {
        public static object binarySearch(int[] arr, int key)
        {
            int min = 0;
            int max = arr.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "None";
        }
    }
}

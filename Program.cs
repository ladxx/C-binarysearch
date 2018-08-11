using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二分查找
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] y = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int rr = BinarySearch(y, 0, y.Length - 1, 8);
            Console.Write(rr);    //12
        }
        public static int BinarySearch(int[] arr, int low, int high, int key)
        {
            int mid = (low + high) / 2;
            if (low > high)
                return -1;
            else
            {
                if (arr[mid] == key)
                    return arr[mid];
                else if (arr[mid] > key)
                    return BinarySearch(arr, low, mid - 1, key);
                else
                    return BinarySearch(arr, mid + 1, high, key);
            }
        }
    }
}

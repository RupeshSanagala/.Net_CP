using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class ArrayMethods
    {
        public void showArrayFun()
        {
            int[] num = { 1, 5, 3, 7, 9 };
            int[] arr = new int[num.Length];

            Array.Sort(num);
            num.CopyTo(arr, 0);
            //Console.WriteLine(Array.IndexOf(arr, 1));
            //Console.WriteLine(Array.BinarySearch(arr, 5));
            //Console.WriteLine(Array.Equals(num, arr));
            //Array.Resize(ref arr, 10);
            //Array.Clear(arr, 2, 2);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
        }

    }
}

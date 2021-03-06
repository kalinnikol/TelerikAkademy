﻿using System;
using System.Text;

namespace CombinationsWithDuplicates
{
    class Program
    {
        static void Main()
        {
            int k = 2;
            int[] arr = new int[k];
            int start = 1;
            int end = 4; //n
            StringBuilder sb = new StringBuilder();
            GenValue(0, arr, start, end, sb);
            Console.WriteLine(sb.ToString().Remove(sb.Length - 1, 1));
        }

        static void GenValue(int index, int[] arr, int start, int end, StringBuilder sb)
        {
            if (index >= arr.Length)
            {
                Print(arr, sb);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    GenValue(index + 1, arr, arr[0], end, sb);
                }
            }
        }

        private static void Print(int[] arr, StringBuilder sb)
        {
            sb.Append("(" + String.Join(" ", arr) + "),");
        }
    }
}

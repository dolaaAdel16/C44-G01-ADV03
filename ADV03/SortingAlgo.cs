using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    internal class SortingAlgo
    {
        #region Before Refactoring
        //public static void BubbleSortAsc(int[] arr)
        //{
        //    if (arr == null || arr.Length == 0) return;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j <arr.Length - i - 1; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //            {
        //                Swap(ref arr[j],ref arr[j + 1]);
        //            }

        //        }
        //    }
        //}

        //public static void BubbleSortDec(int[] arr)
        //{
        //    if (arr == null || arr.Length == 0) return;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < arr.Length - i - 1; j++)
        //        {
        //            if (arr[j] < arr[j + 1])
        //            {
        //                Swap(ref arr[j], ref arr[j + 1]);
        //            }

        //        }
        //    }
        //} 
        #endregion

        #region Little Change
        //public static void BubbleSortDec(int[] arr)
        //{
        //    if (arr == null || arr.Length == 0) return;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < arr.Length - i - 1; j++)
        //        {
        //            if (StringConditions.CompareSmaller(arr[j], arr[j + 1]))
        //            {
        //                Swap(ref arr[j], ref arr[j + 1]);
        //            }

        //        }
        //    }
        //}
        //public static void BubbleSortAsc(int[] arr)
        //{
        //    if (arr == null || arr.Length == 0) return;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < arr.Length - i - 1; j++)
        //        {
        //            if (StringConditions.CompareGtr(arr[j], arr[j + 1]))
        //            {
        //                Swap(ref arr[j], ref arr[j + 1]);
        //            }

        //        }
        //    }
        //} 
        #endregion

        #region Before Generic

        //public delegate bool SortingDelegate(int a, int b);
        //public delegate bool SortingDelegateString(string a, string b);
        //public static void BubbleSort(int[] arr, SortingDelegate reference)
        //{
        //    if (arr == null || arr.Length == 0) return;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < arr.Length - i - 1; j++)
        //        {
        //            if (reference.Invoke(arr[j], arr[j + 1]))
        //            {
        //                Swap(ref arr[j], ref arr[j + 1]);
        //            }

        //        }
        //    }
        //}
        //public static void BubbleSortString(string[] arr, SortingDelegateString reference)
        //{
        //    if (arr == null || arr.Length == 0) return;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < arr.Length - i - 1; j++)
        //        {
        //            if (reference.Invoke(arr[j], arr[j + 1]))
        //            {
        //                Swap(ref arr[j], ref arr[j + 1]);
        //            }

        //        }
        //    }
        //} 
        #endregion

        public delegate bool SortingDelegate<T>(T a, T b);
        public static void BubbleSort<T>(T[] arr, SortingDelegate<T> reference)
        {
            if (arr == null || arr.Length == 0) return;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (reference.Invoke(arr[j], arr[j + 1]))
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }

                }
            }
        }
        private static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}

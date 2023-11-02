﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SortingAlgorithms
{
    public class SelectionSort
    {
        public static void Sort<T>(T[] array)
            where T:IComparable
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int minIndex = i;
                T minValue = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue)<0)
                    {
                        minIndex = j;
                        minValue = array[minIndex];
                    }
                }
                Sorting.Swap<T>(array, i, minIndex);
            }
        }
        public static void Sort<T>(T[] array, 
            Shared.SortDirection sortDirection = Shared.SortDirection.Asceding)
            where T:IComparable
        {
            var comparer = new Shared.CustomComparer<T>(sortDirection, Comparer<T>.Default);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (comparer.Compare(array[j], array[i]) >= 0)
                        continue;

                    Sorting.Swap<T>(array, i, j);
                }
            }
        }
    }
}

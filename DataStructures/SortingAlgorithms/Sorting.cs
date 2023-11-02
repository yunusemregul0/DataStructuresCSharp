﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SortingAlgorithms
{
    public class Sorting
    {
        public static void Swap<T>(T[] array, int first, int second)
        {
            var temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}

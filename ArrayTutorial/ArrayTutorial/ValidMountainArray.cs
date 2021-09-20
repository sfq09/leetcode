using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayTutorial
{
    class ValidMountainArray
    {
        public static bool CheckValidMountainArray(int[] arr)
        {
            if (arr.Length < 3) return false;
            int i = 0, j = 0;
            while (i<arr.Length-1 && arr[i] < arr[i+1])
            {
                i++;
            }
            if (i == 0 || i == arr.Length - 1 || arr[i] == arr[i + 1]) return false;

            while (i < arr.Length - 1 && arr[i] > arr[i + 1] )
            {
                i++;
            }
            if (i == arr.Length - 1)
            {
                return true;
            }
            return false;
            
        }


    }
}

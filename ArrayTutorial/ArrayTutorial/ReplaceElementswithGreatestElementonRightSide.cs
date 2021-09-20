using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayTutorial
{
    class ReplaceElementswithGreatestElementonRightSide
    {
        public static int[] ReplaceElements(int[] arr)
        {
            int temp = -1;
            int max = arr[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                temp = arr[i];
                arr[i] = max;
                if (temp > max)
                {
                    max = temp;
                }
                
            }
            arr[arr.Length - 1] = -1;
            return arr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayTutorial
{
   
    class DuplicateZeros
    {
        private static int[] result;// = new int[arr.Length];

        //NOT Correct way as per the question
        public static int[] GetDuplicateZeros(int[] arr)
        {
            result = new int[arr.Length];
            for (int i=0, k=0; i < arr.Length && k<arr.Length; i++,k++)
            {
                result[k] = arr[i];
                if (arr[i] == 0)
                {
                        if (++k < arr.Length)
                        result[k] = arr[i];
                }

            }
            result.CopyTo(arr, 0);
            return arr;
        }

        public static int [] GetInPlaceDuplicateZeros(int[] arr)
        {
            int zeros = 0;
            int ignoreLastChar = 0;
           //count zeros
           for(int i=0; i < arr.Length-zeros; i++)
            {
                if (arr[i]==0)
                {
                    if (arr.Length-1 == i +zeros)
                    {
                        ignoreLastChar = 1;
                        arr[arr.Length - 1] = 0;
                        break;
                    }
                    zeros++;
                }
            }
            for (int i = (arr.Length- 1-ignoreLastChar) ; i >= zeros; i--)
            {
                arr[i] = arr[i - zeros];
                if (arr[i - zeros] == 0) {
                    arr[--i] = 0; 
                    --zeros;
                }
               
            }

            return arr;
        }

       

    }
}

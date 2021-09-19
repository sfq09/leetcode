using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayTutorial
{
    class CheckIfNandItsDoubleExist
    {
        public static bool CheckIfNandItsDoubleExists(int[] arr)
        {
            int length = arr.Length;
            HashSet<int> doubles = new HashSet<int>();
            int z = -1;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] !=0)
                {
                    doubles.Add(2 * arr[i]);
                }
                else
                {
                    z = i;
                }
                
            }


            for (int i = 0; i < length; i++)
            {
                if (doubles.Contains(arr[i]) || (arr[i] ==0 && i!=z)) return true;

            }

            return false;
        }
    }
}

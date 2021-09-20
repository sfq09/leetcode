using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayTutorial
{
    class SortArrayByParity
    {
        public static int[] DoSortArrayByParity(int[] nums)
        {
            if (nums.Length == 0)
            {
                return nums;
            }
            int oddPointer = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i]%2 != 0)
                {
                    int temp = nums[i];
                    for (int j = i; j < oddPointer; j++)
                    {
                        nums[j] = nums[j + 1];

                    }
                    nums[oddPointer--] = temp;
                }
            }

            return nums;

        }
    }
}

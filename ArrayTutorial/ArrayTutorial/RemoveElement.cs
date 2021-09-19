using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayTutorial
{
    class RemoveElement
    {
        public static int[] RemoveElementFromArray(int[] nums, int val)
        {
            int length = nums.Length;
            for (int i = length-1; i >= 0; i--)
            {
                if (nums[i] == val)
                {
                    for (int k = i; k < length-1; k++)
                    {
                        nums[k] = nums[k + 1];
                    }
                    length--;
                }
            }
            return nums;
        }

        public static void RemoveDuplicatesfromSortedArray(int[] nums)
        {
            int length = nums.Length;
            for (int i = length-1; i > 0; i--)
            {
                if(nums[i] == nums[i - 1])
                {
                    for (int k = i; k < length-1; k++)
                    {
                        nums[k] = nums[k + 1];
                    }
                    length--;
                }
            }

        }
    }
}

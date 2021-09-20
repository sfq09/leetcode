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


        public static int[] RemoveElementImproved(int[] nums, int val)
        {
            int length = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[length++] = nums[i];
                }
            }
            GC.Collect();
            return nums;
        }

        public static void RemoveDuplicatesfromSortedArray(int[] nums)
        {
            int length = nums.Length;
            for (int i = length - 1; i > 0; i--)
            {
                if (nums[i] == nums[i - 1])
                {
                    for (int k = i; k < length - 1; k++)
                    {
                        nums[k] = nums[k + 1];
                    }
                    length--;
                }
            }
        }
            public static  int RemoveDuplicates(int[] nums)
            {
            if (nums == null || nums.Length < 1) return 0;
            else if (nums.Length == 1) return 1;
                int length = 0;
                int index = 0;
                while (index<nums.Length-1)
                {
                 if(nums[index] != nums[index + 1])
                 {
                    nums[length++] = nums[index];
                 }

                index++;
                }

                nums[length] = nums[index];
                return length+1;
            

           // return length+1;
            }
        }
}

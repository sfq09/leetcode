using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayTutorial
{
    class MoveZeroes
    {
        public static  int[] DoMoveZeros(int[] nums)
        {
            if (nums.Length==0)
            {
                return nums;
            }
            int zerosPointer = nums.Length - 1;
            for (int i = nums.Length-1; i >=0; i--)
            {
                if (nums[i] == 0)
                {
                    for (int j = i; j < zerosPointer; j++)
                    {
                        nums[j] = nums[j + 1];
                   
                    }
                    nums[zerosPointer--] = 0;
                }
            }
            return nums;
        }
    }
}

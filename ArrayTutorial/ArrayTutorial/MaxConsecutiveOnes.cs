using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayTutorial
{
    class MaxConsecutiveOnes
    {
        

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxConsecutiveOnes=0;
            int temp = 0;
            foreach(var num in nums)
            {
                if(num == 1)
                {
                    temp++;
                    maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, temp);
                }
                else
                {
                    temp = 0;
                }
                //if(temp > maxConsecutiveOnes)
                //{
                //    maxConsecutiveOnes = temp;
                //}
            }
            return maxConsecutiveOnes;
        }

    }
}

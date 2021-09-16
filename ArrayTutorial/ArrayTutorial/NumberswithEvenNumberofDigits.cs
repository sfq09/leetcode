using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayTutorial
{
    class NumberswithEvenNumberofDigits
    {
        public static int FindNumbers(int[] nums)
        {
            int NumberswithEvenNumberofDigits = 0;

            foreach ( int num in nums)
            {
                int temp = num;
                int Digitcount = 1;
                while(temp > 9)
                {
                    temp /= 10;
                    Digitcount++;
                }
                if (Digitcount % 2 == 0 )
                    NumberswithEvenNumberofDigits++;
            }
            return NumberswithEvenNumberofDigits;

        }
    }
}

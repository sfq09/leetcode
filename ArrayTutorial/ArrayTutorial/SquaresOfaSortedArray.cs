using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayTutorial
{
    class SquaresOfaSortedArray
    {

            public static int[] SortedSquares(int[] nums)
            {
                int K = 0;
                for (K = 0; K < nums.Length; K++)
                    if (nums[K] >= 0)
                        break;


                int i = K - 1; // Initial index of first half
                int j = K; // Initial index of second half
                int ind = 0; // Initial index of temp array

                // store sorted array
                int[] temp = new int[nums.Length];
                while (i >= 0 && j < nums.Length)
                {
                    if (nums[i] * nums[i] < nums[j] * nums[j])
                    {
                        temp[ind] = nums[i] * nums[i];
                        i--;
                    }
                    else
                    {
                        temp[ind] = nums[j] * nums[j];
                        j++;
                    }
                    ind++;
                }

                /* Copy the remaining elements of first half */
                while (i >= 0)
                {
                    temp[ind] = nums[i] * nums[i];
                    i--;
                    ind++;
                }

                /* Copy the remaining elements of second half */
                while (j < nums.Length)
                {
                    temp[ind] = nums[j] * nums[j];
                    j++;
                    ind++;
                }

                // copy 'temp' array into original array
                for (int l = 0; l < nums.Length; l++)
                    nums[l] = temp[l];

                return nums;
            }


        }
         
        }
    


using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayTutorial
{
    class MergeSortedArray
    {
        public static int[] GetMergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {
            int i=0, j=0;
            while (j<n && i < n + m)
            {
                if(i < m+j && nums1[i] >= nums2[j] )
                {
                    for (int l = j+m; l > i; l--)
                    {
                        nums1[l] = nums1[l - 1];
                    }
                    nums1[i] = nums2[j];
                    j++;
                }
                i++;
                
            }
            while (j < n)
            {
               nums1[m + j] = nums2[j];
               j++;
            }

            //only to test
            return nums1;
        }
    }
}

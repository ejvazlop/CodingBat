using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class AP1Helper
    {
        internal static int Average(int[] nums, int start, int end)
        {
            int sum = 0, n = start;

            while (n < end)
            {
                sum += nums[n++];
            }

            return sum / (end - start);
        }

        internal static bool IsEndy(int n)
        {
            return (n >= 0 && n <= 10) || (n >= 90 && n <= 100);
        }

        internal static int LargestSpecial(int[] nums)
        {
            int largest = 0;

            foreach (int n in nums)
            {
                if (n > largest && n % 10 == 0) largest = n;
            }

            return largest;
        }
    }
}

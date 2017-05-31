using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    public static class RecursionHelper
    {
        internal static int SumArray(int[] a, int index)
        {
            if (index == a.Length - 1) return a[index];
            return a[index] + SumArray(a, index + 1);
        }

        internal static bool SplitOddCheck(int[] nums, int x, int y, int i)
        {
            if (i >= nums.Length) return (x % 10 == 0 && y % 2 == 1) || (x % 2 == 1 && y % 10 == 0);
            return SplitOddCheck(nums, x + nums[i], y, i + 1) || SplitOddCheck(nums, x, y + nums[i], i + 1);
        }

        internal static bool Split53Check(int[] nums, int count, int i)
        {
            if (i >= nums.Length) return count == 0;            
            if (nums[i] % 3 == 0 && nums[i] % 5 > 0) return Split53Check(nums, count - nums[i], i + 1);
            else if (nums[i] % 5 == 0) return Split53Check(nums, count + nums[i], i + 1);
            else return Split53Check(nums, count + nums[i], i + 1) || Split53Check(nums, count - nums[i], i + 1);
        }
    }
}

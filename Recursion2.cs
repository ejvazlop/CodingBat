using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class Recursion2
    {
        public static bool GroupSum(int start, int[] nums, int target)
        {
            if (start >= nums.Length) return target == 0;
            if (GroupSum(start + 1, nums, target - nums[start])) return true;
            else return GroupSum(start + 1, nums, target);
        }

        public static bool GroupSum6(int start, int[] nums, int target)
        {
            if (start >= nums.Length) return target == 0;
            if (nums[start] == 6) return GroupSum6(start + 1, nums, target - 6);
            return GroupSum6(start + 1, nums, target - nums[start]) || GroupSum6(start + 1, nums, target);
        }

        public static bool GroupNoAdj(int start, int[] nums, int target)
        {
            if (start >= nums.Length) return target == 0;
            return GroupNoAdj(start + 2, nums, target - nums[start]) || GroupNoAdj(start + 1, nums, target);
        }

        public static bool GroupSum5(int start, int[] nums, int target)
        {
            if (start >= nums.Length) return target == 0;
            if (start + 1 < nums.Length && nums[start] % 5 == 0 && nums[start + 1] == 1) return GroupSum5(start + 2, nums, target - nums[start]);
            if (nums[start] % 5 == 0) return GroupSum5(start + 1, nums, target - nums[start]);
            return GroupSum5(start + 1, nums, target - nums[start]) || GroupSum5(start + 1, nums, target);
        }

        public static bool GroupSumClump(int start, int[] nums, int target)
        {
            int count = 0;
            if (start >= nums.Length) return target == 0;
            for (int i = start; i < nums.Length && nums[start] == nums[i]; i++) count++;
            return GroupSumClump(start + count, nums, target - nums[start] * count) || GroupSumClump(start + count, nums, target);
        }

        public static bool SplitArray(int[] nums)
        {
            if (nums.Length == 0) return true;
            if (nums.Length == 2) return nums[0] == nums[1];
            return RecursionHelper.SumArray(nums, 0) % 2 == 0;
        }

        public static bool SplitOdd10(int[] nums)
        {
            return RecursionHelper.SplitOddCheck(nums, 0, 0, 0);
        }

        public static bool Split53(int[] nums)
        {
            return RecursionHelper.Split53Check(nums, 0, 0);
        }
    }
}

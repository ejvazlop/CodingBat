using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class Array1
    {
        public static bool FirstLast6(int[] nums)
        {
            return nums[0] == 6 || nums[nums.Length - 1] == 6;
        }

        public static bool SameFirstLast(int[] nums)
        {
            return nums.Length > 0 && nums[0] == nums[nums.Length - 1];
        }

        public static int[] MakePi()
        {
            return new int[] { 3, 1, 4 };
        }

        public static bool CommonEnd(int[] a, int[] b)
        {
            return a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1];
        }

        public static int Sum3(int[] nums)
        {
            return nums[0] + nums[1] + nums[2];
        }

        public static int[] RotateLeft3(int[] nums)
        {
            return new int[] { nums[1], nums[2], nums[0] };
        }

        public static int[] Reverse3(int[] nums)
        {
            return new int[] { nums[2], nums[1], nums[0] };
        }

        public static int[] MaxEnd3(int[] nums)
        {
            int max = Math.Max(nums[0], nums[2]);

            return new int[] { max, max, max };
        }

        public static int Sum2(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            else if (nums.Length == 1)
            {
                return nums[0];
            }
            else
            {
                return nums[0] + nums[1];
            }
        }

        public static int[] MiddleWay(int[] a, int[] b)
        {
            return new int[] { a[1], b[1] };
        }

        public static int[] MakeEnds(int[] nums)
        {
            return new int[] { nums[0], nums[nums.Length - 1] };
        }

        public static bool Has23(int[] nums)
        {
            return nums[0] == 2 || nums[0] == 3 || nums[1] == 2 || nums[1] == 3;
        }

        public static bool No23(int[] nums)
        {
            return nums[0] != 2 && nums[1] != 2 && nums[0] != 3 && nums[1] != 3;
        }

        public static int[] MakeLast(int[] nums)
        {
            int elements = nums.Length * 2;
            int[] doubleNums = new int[elements];

            doubleNums[elements - 1] = nums[nums.Length - 1];
            return doubleNums;
        }

        public static bool Double23(int[] nums)
        {
            return nums.Length == 2
                && ((nums[0] == 2 && nums[1] == 2)
                     || (nums[0] == 3 && nums[1] == 3));
        }

        public static int[] Fix23(int[] nums)
        {
            if (nums[0] == 2 && nums[1] == 3)
            {
                nums[1] = 0;
            }

            if (nums[1] == 2 && nums[2] == 3)
            {
                nums[2] = 0;
            }

            return nums;
        }

        public static int Start1(int[] a, int[] b)
        {
            int ones = 0;

            if (a.Length > 0 && a[0] == 1)
            {
                ones++;
            }

            if (b.Length > 0 && b[0] == 1)
            {
                ones++;
            }

            return ones;
        }

        public static int[] BiggerTwo(int[] a, int[] b)
        {
            return a[0] + a[1] >= b[0] + b[1] ? a : b;
        }

        public static int[] MakeMiddle(int[] nums)
        {
            return new int[] { nums[nums.Length / 2 - 1], nums[nums.Length / 2] };
        }

        public static int[] PlusTwo(int[] a, int[] b)
        {
            return new int[] { a[0], a[1], b[0], b[1] };
        }

        public static int[] SwapEnds(int[] nums)
        {
            int first = nums[0];
            nums[0] = nums[nums.Length - 1];
            nums[nums.Length - 1] = first;

            return nums;
        }

        public static int[] MidThree(int[] nums)
        {
            return new int[] { nums[nums.Length / 2 - 1], nums[nums.Length / 2], nums[nums.Length / 2 + 1] };
        }

        public static int MaxTriple(int[] nums)
        {
            int first, middle, last, max;

            first = nums[0];
            middle = nums[nums.Length / 2];
            last = nums[nums.Length - 1];
            max = first;

            if (middle > max)
            {
                max = middle;
            }

            if (last > max)
            {
                max = last;
            }

            return max;
        }

        public static int[] FrontPiece(int[] nums)
        {
            int[] frontPiece;

            if (nums.Length >= 2)
            {
                frontPiece = new int[] { nums[0], nums[1] };
            }
            else if (nums.Length > 0)
            {
                frontPiece = new int[] { nums[0] };
            }
            else
            {
                frontPiece = new int[0];
            }

            return frontPiece;
        }

        public static bool Unlucky1(int[] nums)
        {
            return (nums[0] == 1 && nums[1] == 3)
                || (nums[1] == 1 && nums[2] == 3)
                || (nums[nums.Length - 3] == 1 && nums[nums.Length - 2] == 3)
                || (nums[nums.Length - 2] == 1 && nums[nums.Length - 1] == 3);
        }

        public static int[] Make2(int[] a, int[] b)
        {
            int[] make = new int[2];

            if (a.Length > 0 && b.Length < 1)
            {
                make[0] = a[0];
                make[1] = a[1];
            }
            else if (a.Length > 0 && b.Length > 0)
            {
                make[0] = a[0];
                make[1] = b[0];
            }
            else
            {
                make[0] = b[0];
                make[1] = b[1];
            }

            return make;
        }

        public static int[] Front11(int[] a, int[] b)
        {
            int[] front;

            if (a.Length > 0 && b.Length > 0)
            {
                front = new int[] { a[0], b[0] };
            }
            else if (a.Length > 0)
            {
                front = new int[] { a[0] };
            }
            else if (b.Length > 0)
            {
                front = new int[] { b[0] };
            }
            else
            {
                front = new int[0];
            }

            return front;
        }
    }
}

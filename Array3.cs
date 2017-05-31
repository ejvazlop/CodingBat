using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class Array3
    {
        public static int MaxSpan(int[] nums)
        {
            int maxSpan = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j + maxSpan < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && j - i + 1 > maxSpan)
                    {
                        maxSpan = j - i + 1;
                    }
                }
            }

            return maxSpan;
        }

        public static int[] Fix34(int[] nums)
        {
            int j = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 3 && nums[i + 1] != 4)
                {
                    if (j == 0) j = i + 1;

                    while (j < nums.Length)
                    {
                        if (nums[j] == 4)
                        {
                            nums[j] = nums[i + 1];
                            nums[i + 1] = 4;
                            i++;
                            break;
                        }

                        j++;
                    }
                }
            }

            return nums;
        }

        public static int[] Fix45(int[] nums)
        {
            int i = 0, j = 0;

            while (i < nums.Length - 1)
            {
                if (nums[i] == 4 && nums[i + 1] != 5)
                {
                    while (j < nums.Length)
                    {
                        if (nums[j] == 5 && (j == 0 || nums[j - 1] != 4))
                        {
                            nums[j] = nums[i + 1];
                            nums[i + 1] = 5;

                            break;
                        }

                        j++;
                    }
                }

                i++;
            }

            return nums;
        }

        public static bool CanBalance(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                int left = 0, right = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (j < i)
                    {
                        left += nums[j];
                    }
                    else
                    {
                        right += nums[j];
                    }
                }

                if (left == right) return true;
            }

            return false;
        }

        public static bool LinearIn(int[] outer, int[] inner)
        {
            int j = 0, count = 0;
            for (int i = 0; i < inner.Length; i++)
            {
                for (; j < outer.Length; j++)
                {
                    if (outer[j] > inner[i]) return false;
                    if (inner[i] == outer[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            return inner.Length == count;
        }

        public static int[] SquareUp(int n)
        {
            int[] squaredUp = new int[n * n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (n - 1 > i + j)
                    {
                        squaredUp[i * n + j] = 0;
                    }
                    else
                    {
                        squaredUp[i * n + j] = n - j;
                    }
                }
            }

            return squaredUp;
        }

        public static int[] SeriesUp(int n)
        {
            int[] series = new int[n * (n + 1) / 2];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    series[index++] = j + 1;
                }
            }

            return series;
        }

        public static int MaxMirror(int[] nums)
        {
            int maxMirror = 0, length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                int count = 0;

                for (int j = i, k = length - 1; k >= i; k--)
                {
                    if (nums[j] == nums[k])
                    {
                        if (++count > maxMirror) maxMirror = count;
                        j++;
                    }
                    else if (nums[j] != nums[k] && j != i)
                    {
                        count = 0;
                        j = i;
                    }
                }
            }

            return maxMirror;
        }

        public static int CountClumps(int[] nums)
        {
            int countClumps = 0, length = nums.Length;
            bool sameClump = false;

            for (int i = 0; i < length - 1; i++)
            {
                if (nums[i] == nums[i + 1] && !sameClump)
                {
                    countClumps++;
                    sameClump = true;
                }
                else if (nums[i] != nums[i + 1])
                {
                    sameClump = false;
                }
            }

            return countClumps;
        }
    }
}

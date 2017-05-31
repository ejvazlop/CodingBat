using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class Array2
    {
        public static int CountEvens(int[] nums)
        {
            int evens = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0) evens++;
            }

            return evens;
        }

        public static int BigDiff(int[] nums)
        {
            int smallest = 0, biggest = 0;

            if (nums.Length > 0) smallest = biggest = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                smallest = Math.Min(smallest, nums[i]);
                biggest = Math.Max(biggest, nums[i]);
            }

            return biggest - smallest;
        }

        public static int CenterAverage(int[] nums)
        {
            int smallest = nums[0], biggest = nums[0], sum = 0, num = nums.Length;

            for (int i = 0; i < num; i++)
            {
                smallest = Math.Min(smallest, nums[i]);
                biggest = Math.Max(biggest, nums[i]);
                sum += nums[i];
            }

            return (sum - smallest - biggest) / (num - 2);
        }

        public static int Sum13(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 13) sum += nums[i];
                else i++;
            }

            return sum;
        }

        public static int Sum67(int[] nums)
        {
            int sum = 0;
            bool inSection = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 6) inSection = true;
                else if (inSection && nums[i] == 7) inSection = false;
                else if (!inSection) sum += nums[i];
            }

            return sum;
        }

        public static bool Has22(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 2 && nums[i] == nums[i + 1]) return true;
            }

            return false;
        }

        public static bool Lucky13(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1 || nums[i] == 3) return false;
            }

            return true;
        }

        public static bool Sum28(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 2)
                    sum += 2;
            }

            return sum == 8;
        }

        public static bool More14(int[] nums)
        {
            int ones = 0, fours = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1) ones++;
                if (nums[i] == 4) fours++;
            }

            return ones > fours;
        }

        public static int[] FizzArray(int n)
        {
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = i;
            }

            return a;
        }

        public static bool Only14(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 1 && nums[i] != 4) return false;
            }

            return true;
        }

        public static string[] FizzArray2(int n)
        {
            string[] s = new string[n];

            for (int i = 0; i < n; i++)
            {
                s[i] = i.ToString();
            }

            return s;
        }

        public static bool No14(int[] nums)
        {
            int ones = 0, fours = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1) ones++;
                if (nums[i] == 4) fours++;
            }

            return ones == 0 || fours == 0;
        }

        public static bool IsEveryWhere(int[] nums, int val)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != val && nums[i + 1] != val) return false;
            }

            return true;
        }

        public static bool Either24(int[] nums)
        {
            bool twos = false, fours = false;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 2 && nums[i + 1] == 2) twos = true;
                if (nums[i] == 4 && nums[i + 1] == 4) fours = true;
            }

            return twos ^ fours;
        }

        public static int MatchUp(int[] nums1, int[] nums2)
        {
            int times = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                if (Math.Abs(nums1[i] - nums2[i]) > 0
                    && Math.Abs(nums1[i] - nums2[i]) <= 2) times++;
            }

            return times;
        }

        public static bool Has77(int[] nums)
        {
            int len = nums.Length;

            for (int i = 0; i < len - 1; i++)
            {
                if (nums[i] == 7 && nums[i + 1] == 7) return true;
                if (i + 2 < len && nums[i] == 7 && nums[i + 2] == 7) return true;
            }

            return false;
        }

        public static bool Has12(int[] nums)
        {
            bool one = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (one && nums[i] == 2) return true;
                if (nums[i] == 1) one = true;
            }

            return false;
        }

        public static bool ModThree(int[] nums)
        {
            int odds = 0, evens = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (odds < 3 && evens < 3)
                {
                    if (nums[i] % 2 == 0)
                    {
                        evens++;
                        odds = 0;
                    }
                    else
                    {
                        odds++;
                        evens = 0;
                    }
                }
            }

            return odds == 3 || evens == 3;
        }

        public static bool HaveThree(int[] nums)
        {
            bool flag = false;
            int threes = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3 && !flag)
                {
                    threes++;
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }

            return threes == 3;
        }

        public static bool TwoTwo(int[] nums)
        {
            int len = nums.Length;
            bool isTrue = true;

            for (int i = 0; i < len; i++)
            {
                if (nums[i] == 2)
                {
                    if ((i > 0 && nums[i - 1] == 2) || (i < len - 1 && nums[i + 1] == 2)) isTrue = true;
                    else if (i == len - 1) isTrue = false;
                    else return false;
                }
            }

            return isTrue;
        }

        public static bool SameEnds(int[] nums, int len)
        {
            int size = nums.Length;

            for (int i = 0; i < len; i++)
            {
                if (nums[i] != nums[size - len + i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool TripleUp(int[] nums)
        {
            for (int i = 0; i <= nums.Length - 3; i++)
            {
                if (nums[i] == nums[i + 1] - 1
                    && nums[i] == nums[i + 2] - 2)
                {
                    return true;
                }
            }

            return false;
        }

        public static int[] FizzArray3(int start, int end)
        {
            int[] array = new int[end - start];

            for (int i = 0; i < end - start; i++)
            {
                array[i] = start + i;
            }

            return array;

        }

        public static int[] ShiftLeft(int[] nums)
        {
            int size = nums.Length;
            int[] shiftNums = new int[size];

            for (int i = 0; i < size; i++)
            {
                shiftNums[i] = nums[(i + 1) % size];
            }

            return shiftNums;
        }

        public static int[] ShiftLeftSameCopy(int[] nums)
        {
            int size = nums.Length;
            int first = 0;

            for (int i = 0; i < size; i++)
            {
                if (i == 0)
                {
                    first = nums[0];
                }

                if (i == size - 1)
                {
                    nums[i] = first;
                }
                else
                {
                    nums[i] = nums[i + 1];
                }

            }

            return nums;
        }

        public static int[] TenRun(int[] nums)
        {
            int last = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 10 == 0) last = nums[i];
                if (last % 10 == 0) nums[i] = last;
            }

            return nums;
        }

        public static int[] Pre4(int[] nums)
        {
            int size = 0;
            int[] pre4;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 4)
                {
                    size = i;
                    break;
                }
            }

            pre4 = new int[size];

            for (int j = 0; j < size; j++)
            {
                pre4[j] = nums[j];
            }

            return pre4;
        }

        public static int[] Post4(int[] nums)
        {
            int len = nums.Length, size = 0, i = len - 1;
            int[] post4;

            while (i >= 0 && nums[i] != 4) i--;
            i++;

            size = len - i;
            post4 = new int[size];

            for (int j = 0; j < size; j++)
            {
                post4[j] = nums[i + j];
            }

            return post4;
        }

        public static int[] NotAlone(int[] nums, int val)
        {
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] == val
                    && val != nums[i - 1]
                    && val != nums[i + 1])
                {
                    if (nums[i - 1] > nums[i + 1])
                    {
                        nums[i] = nums[i - 1];
                    }
                    else
                    {
                        nums[i] = nums[i + 1];
                    }
                }
            }

            return nums;
        }

        public static int[] ZeroFront(int[] nums)
        {
            int firstNonZeroPosition = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    nums[i] = nums[firstNonZeroPosition];
                    nums[firstNonZeroPosition++] = 0;
                }
            }

            return nums;
        }

        public static int[] WithoutTen(int[] nums)
        {
            int size = nums.Length, index = 0;
            int[] withoutTen = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (nums[i] != 10)
                {
                    withoutTen[index++] = nums[i];
                }
            }

            return withoutTen;
        }

        public static int[] WithoutTenSameCopy(int[] nums)
        {
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 10)
                {
                    nums[i] = 0;
                }
                else
                {
                    int temp = nums[i];
                    nums[i] = 0;
                    nums[index++] = temp;
                }
            }

            return nums;
        }

        public static int[] ZeroMax(int[] nums)
        {
            int odd = -1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == 0 && odd > -1)
                {
                    nums[i] = odd;
                }
                else if (nums[i] % 2 != 0 && nums[i] > odd)
                {
                    odd = nums[i];
                }
            }

            return nums;
        }

        public static int[] EvenOdd(int[] nums)
        {
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    int temp = nums[index];
                    nums[index] = nums[i];
                    nums[i] = temp;

                    index++;
                }
            }

            return nums;
        }

        public static string[] FizzBuzz(int start, int end)
        {
            int size = end - start;
            string[] fizzBuzz = new string[size];

            for (int i = 0; i < size; i++)
            {
                if ((start + i) % 15 == 0) fizzBuzz[i] = "FizzBuzz";
                else if ((start + i) % 5 == 0) fizzBuzz[i] = "Buzz";
                else if ((start + i) % 3 == 0) fizzBuzz[i] = "Fizz";
                else fizzBuzz[i] = (start + i).ToString();
            }

            return fizzBuzz;
        }
    }
}

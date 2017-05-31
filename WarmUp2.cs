using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class WarmUp2
    {
        public static string StringTimes(string s, int n)
        {
            string stringTimes = String.Empty;

            for (int i = 0; i < n; i++)
            {
                stringTimes += s;
            }

            return stringTimes;
        }

        public static string FrontTimes(string s, int n)
        {
            string frontTimes = String.Empty;

            if (s.Length < 3)
            {
                return s;
            }
            else
            {
                s = s.Substring(0, 3);

                for (int i = 0; i < n; i++)
                {
                    frontTimes += s;
                }

                return frontTimes;
            }
        }

        public static int CountXX(string s)
        {
            int countXX = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s.Substring(i, 2) == "xx")
                {
                    countXX++;
                }
            }

            return countXX;
        }

        public static bool DoubleX(string s)
        {
            return s.IndexOf('x') < s.Length && s[s.IndexOf('x') + 1] == 'x';
        }

        public static string StringBits(string s)
        {
            string stringBits = String.Empty;
            int i = 0;

            while (i < s.Length)
            {
                stringBits += s[i].ToString();
                i += 2;
            }

            return stringBits;
        }

        public static string StringSplosion(string s)
        {
            string stringSplosion = String.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                stringSplosion += s.Substring(0, i + 1);
            }

            return stringSplosion;
        }

        public static int Last2(string s)
        {
            int counter = 0;

            if (s.Length < 4)
            {
                return 0;
            }

            string last2 = s.Substring(s.Length - 2);
            s = s.Remove(s.Length - 2);

            for (int i = 0; i + 2 < s.Length; i++)
            {
                if (String.Compare(s.Substring(i, 2), last2) == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int ArrayCount9(int[] nums)
        {
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 9)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static bool ArrayFront9(int[] nums)
        {
            for (int i = 0; i < 4 && i < nums.Length; i++)
            {
                if (nums[i] == 9)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Array123(int[] nums)
        {
            bool one, two, three;
            one = two = three = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    one = true;
                }

                if (nums[i] == 2)
                {
                    two = true;
                }

                if (nums[i] == 3)
                {
                    three = true;
                }

                if (one && two && three)
                {
                    return true;
                }
            }

            return false;
        }

        public static int StringMatch(string a, string b)
        {
            int count = 0;
            int length = a.Length >= b.Length ? b.Length : a.Length;

            for (int i = 0; i < length - 1; i++)
            {
                if (String.Compare(a.Substring(i, 2), b.Substring(i, 2)) == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static string StringX(string s)
        {
            for (int i = s.Length - 2; i > 0; i--)
            {
                if (s[i] == 'x')
                {
                    s = s.Remove(i, 1);
                }
            }

            return s;
        }

        public static string AltPairs(string s)
        {
            string altPairs = String.Empty;

            for (int i = 0; i < s.Length; i += 4)
            {
                if (i < s.Length - 1)
                {
                    altPairs += s.Substring(i, 2);
                }
                else
                {
                    altPairs += s.Substring(i);
                }
            }

            return altPairs;
        }

        public static string StringYak(string s)
        {
            string stringYak = String.Empty;
            int i = 0;

            if (s.Length < 3)
            {
                stringYak = s;
            }

            while (i < s.Length)
            {
                if (i + 2 < s.Length && s[i] == 'y' && s[i + 2] == 'k')
                {
                    i += 3;
                }
                else
                {
                    stringYak += s[i++].ToString();
                }
            }

            return stringYak;
        }

        public static int Array667(int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 6 && (nums[i + 1] == 6 || nums[i + 1] == 7))
                {
                    count++;
                }
            }

            return count;
        }

        public static bool NoTriples(int[] nums)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == nums[i + 1] && nums[i] == nums[i + 2])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool Has271(int[] nums)
        {
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i + 1] == nums[i] + 5 && Math.Abs(nums[i + 2] - nums[i]) <= 2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

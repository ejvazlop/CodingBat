using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class Recursion1
    {
        public static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }

        public static int BunnyEars(int bunnies)
        {
            if (bunnies < 1) return 0;
            return 2 + BunnyEars(bunnies - 1);
        }

        public static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }

        public static int BunnyEars2(int bunnies)
        {
            if (bunnies == 0) return 0;
            if (bunnies % 2 == 1) return 2 + BunnyEars2(bunnies - 1);
            return 3 + BunnyEars2(bunnies - 1);
        }

        public static int Triangle(int rows)
        {
            if (rows == 0) return 0;
            return rows + Triangle(rows - 1);
        }

        public static int SumDigits(int n)
        {
            if (n == 0) return 0;
            return n % 10 + SumDigits(n / 10);
        }

        public static int Count7(int n)
        {
            if (n == 0) return 0;
            return (n % 10 == 7 ? 1 : 0) + Count7(n / 10);
        }

        public static int Count8(int n)
        {
            if (n == 0) return 0;
            if (n % 100 == 88) return 2 + Count8(n / 10);
            return (n % 10 == 8 ? 1 : 0) + Count8(n / 10);
        }

        public static int PowerN(int b, int n)
        {
            if (n == 1) return b;
            return b * PowerN(b, n - 1);
        }

        public static int CountX(string str)
        {
            if (str.Length == 0) return 0;
            return (str.Substring(0, 1) == "x" ? 1 : 0) + CountX(str.Substring(1));
        }

        public static int CountHi(string str)
        {
            if (str.Length < 2) return 0;
            return (str.Substring(0, 2) == "hi" ? 1 : 0) + CountHi(str.Substring(1));
        }

        public static string ChangeXY(string str)
        {
            if (str.Length == 0) return str;
            return (str.Substring(0, 1) == "x" ? "y" : str.Substring(0, 1))
                + ChangeXY(str.Substring(1));
        }

        public static string ChangePi(string str)
        {
            if (str.Length < 2) return str;
            if (str.Substring(0, 2) == "pi") return "3.14" + ChangePi(str.Substring(2));
            return str.Substring(0, 1) + ChangePi(str.Substring(1));
        }

        public static string NoX(string str)
        {
            if (str.Length < 1) return str;
            return (str.Substring(0, 1) == "x" ? String.Empty : str.Substring(0, 1)) + NoX(str.Substring(1));
        }

        public static bool Array6(int[] nums, int index)
        {
            if (index == nums.Length) return false;
            return nums[index] == 6 ? true : Array6(nums, index + 1);
        }

        public static int Array11(int[] nums, int index)
        {
            if (index == nums.Length) return 0;
            return (index < nums.Length && nums[index] == 11 ? 1 : 0) + Array11(nums, index + 1);
        }

        public static bool Array220(int[] nums, int index)
        {
            return index < nums.Length - 1 && (nums[index] * 10 == nums[index + 1] || Array220(nums, index + 1));
        }

        public static string AllStar(string str)
        {
            if (str.Length <= 1) return str;
            return str.Substring(0, 1) + "*" + AllStar(str.Substring(1));
        }

        public static string PairStar(string str)
        {
            if (str.Length < 2) return str;
            if (str.Substring(0, 1) == str.Substring(1, 1)) return str.Substring(0, 1) + "*" + PairStar(str.Substring(1));
            return str.Substring(0, 1) + PairStar(str.Substring(1));
        }

        public static string EndX(string str)
        {
            if (str.Length == 1) return str;
            if (str.Substring(0, 1).Equals("x")) return EndX(str.Substring(1)) + str.Substring(0, 1);
            return str.Substring(0, 1) + EndX(str.Substring(1));
        }

        public static int CountPairs(string str)
        {
            if (str.Length < 3) return 0;
            return (str.Substring(0, 1).Equals(str.Substring(2, 1)) ? 1 : 0) + CountPairs(str.Substring(1));
        }

        public static int CountAbc(string str)
        {
            if (str.Length < 3) return 0;
            return ((str.Substring(0, 3).Equals("abc") || str.Substring(0, 3).Equals("aba")) ? 1 : 0) + CountAbc(str.Substring(1));
        }

        public static int Count11(string str)
        {
            if (str.Length < 2) return 0;
            if (str.Substring(0, 2).Equals("11")) return 1 + Count11(str.Substring(2));
            return Count11(str.Substring(1));
        }

        public static string StringClean(string str)
        {
            if (str.Length == 1) return str;
            if (str.Substring(0, 1).Equals(str.Substring(1, 1))) return StringClean(str.Substring(1));
            return str.Substring(0, 1) + StringClean(str.Substring(1));
        }

        public static int CountHi2(string str)
        {
            if (str.Length < 2) return 0;
            if (str.Length >= 3 && str.Substring(0, 3).Equals("xhi")) return CountHi2(str.Substring(3));
            if (str.Substring(0, 2).Equals("hi")) return 1 + CountHi2(str.Substring(2));
            return CountHi2(str.Substring(1));
        }

        public static string ParentBit(string str)
        {
            if (str.Substring(0, 1).Equals("(") && str.Substring(str.Length - 1, 1).Equals(")")) return str;
            if (str.Substring(0, 1).Equals("(")) return ParentBit(str.Remove(str.Length - 1, 1));
            return ParentBit(str.Substring(1));
        }

        public static bool NestParen(string str)
        {
            if (str.Length == 0) return true;
            return str.Substring(0, 1).Equals("(") && str.Substring(str.Length - 1, 1).Equals(")") ? NestParen(str.Remove(str.Length - 1, 1).Remove(0, 1)) : false;
        }

        public static int StrCount(string str, string sub)
        {
            if (str.Length < sub.Length) return 0;
            if (str.Substring(0, sub.Length).Equals(sub)) return 1 + StrCount(str.Substring(sub.Length), sub);
            return StrCount(str.Substring(1), sub);
        }

        public static bool StrCopies(string str, string sub, int n)
        {
            if (str.Length < sub.Length) return n == 0;
            if (str.Substring(0, sub.Length).Equals(sub)) return StrCopies(str.Substring(1), sub, n - 1);
            return StrCopies(str.Substring(1), sub, n);
        }

        public static int StrDist(string str, string sub)
        {
            if (str.Length < sub.Length) return 0;
            if (str.Substring(0, sub.Length).Equals(str.Substring(str.Length - sub.Length)) && str.Substring(0, sub.Length).Equals(sub)) return str.Length;
            if (str.Substring(0, sub.Length).Equals(sub)) return StrDist(str.Remove(str.Length - 1), sub);
            return StrDist(str.Substring(1), sub);
        }
    }
}

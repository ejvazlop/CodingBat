using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class Logic2
    {
        public static bool MakeBricks(int small, int big, int goal)
        {
            if (small >= goal)
            {
                return true;
            }
            if (big > 0 && goal % (big * 5) <= small)
            {
                return true;
            }

            return false;
        }

        public static int LoneSum(int a, int b, int c)
        {
            if (a == b && b == c) return 0;
            if (a == b) return c;
            if (a == c) return b;
            if (b == c) return a;
            return a + b + c;
        }

        public static int LuckySum(int a, int b, int c)
        {
            if (a == 13) return 0;
            if (b == 13) return a;
            if (c == 13) return a + b;
            return a + b + c;
        }

        public static int NoTeenSum(int a, int b, int c)
        {
            return Logic2.FixTeen(a) + Logic2.FixTeen(b) + Logic2.FixTeen(c);
        }

        private static int FixTeen(int n)
        {
            return (n < 15 && n > 12) || (n > 16 && n < 20) ? 0 : n;
        }

        public static int RoundSum(int a, int b, int c)
        {
            return Logic2.Round10(a) + Logic2.Round10(b) + Logic2.Round10(c);
        }

        private static int Round10(int n)
        {
            return n % 10 >= 5 ? (n / 10 + 1) * 10 : n / 10 * 10;
        }

        public static bool CloseFar(int a, int b, int c)
        {
            return (Logic2.IsClose(a, b) && Logic2.IsFar(c, a, b))
                || (Logic2.IsClose(a, c) && Logic2.IsFar(b, a, c));
        }

        private static bool IsFar(int i, int j, int k)
        {
            return Math.Abs(i - j) >= 2 && Math.Abs(i - k) >= 2;
        }

        private static bool IsClose(int i, int j)
        {
            return Math.Abs(i - j) <= 1;
        }

        public static int BlackJack(int a, int b)
        {
            if (a > 21 && b > 21) return 0;
            if (a <= 21 && b > 21) return a;
            if (b <= 21 && a > 21) return b;
            return a > b ? a : b;
        }

        public static bool EvenlySpaced(int a, int b, int c)
        {
            if (a > b && a > c && b > c) return a - b == b - c;
            if (a > b && a > c && c > b) return a - c == c - b;
            if (b > a && b > c && a > c) return b - a == a - c;
            if (b > a && b > c && c > a) return b - c == c - a;
            if (c > a && c > b && a > b) return c - a == a - b;
            return c - b == b - a;
        }

        public static int MakeChocolate(int small, int big, int goal)
        {
            //if (big * 5 + small < goal || small < goal % 5) return -1;
            //if (goal > big * 5) return goal - big * 5;
            //return goal % 5;

            int remainder = big * 5 <= goal ? goal - big * 5 : goal % 5;
            return remainder <= small ? remainder : -1;
        }
    }
}

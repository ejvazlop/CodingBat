using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class Warmup1
    {
        public static bool SleepIn(bool weekDay, bool vacation)
        {
            return (!weekDay || vacation) ? true : false;
        }

        public static bool MonkeyTrouble(bool aSmile, bool bSmile)
        {
            return aSmile == bSmile;
        }

        public static int SumDouble(int a, int b)
        {
            return a == b ? (a + b) * 2 : a + b;
        }

        public static int Diff21(int n)
        {
            return (n > 21) ? (n - 21) * 2 : 21 - n;
        }

        public static bool ParrotTrouble(bool talking, int hour)
        {
            return talking && (hour < 7 || hour > 20);
        }

        public static bool Makes10(int a, int b)
        {
            return (a + b == 10 || a == 10 || b == 10);
        }

        public static bool NearHundred(int n)
        {
            return Math.Abs(100 - n) <= 10 || Math.Abs(200 - n) <= 10;
        }

        public static bool PosNeg(int a, int b, bool negative)
        {
            return negative ? a < 0 && b < 0 : (a < 0 && b > 0) || (a > 0 && b < 0);
        }

        public static string NotString(string s)
        {
            if (s.Length < 3 || String.Compare(s.Substring(0, 3), "not") != 0)
            {
                return "not " + s;
            }
            else
            {
                return s;
            }
        }

        public static string MissingChar(string s, int n)
        {
            if (!String.IsNullOrEmpty(s) && n >= 0 && n <= s.Length - 1)
            {
                return s.Remove(n, 1);
            }
            else
            {
                return s;
            }
        }

        public static string FrontBack(string s)
        {
            if (s.Length > 1)
            {
                return s[s.Length - 1] + s.Substring(1, s.Length - 2) + s[0];
            }
            else
            {
                return s;
            }
        }

        public static string Front3(string s)
        {
            if (s.Length < 3)
            {
                return s + s + s;
            }
            else
            {
                string front3 = s.Substring(0, 3);
                return front3 + front3 + front3;
            }
        }

        public static string BackAround(string s)
        {
            return s[s.Length - 1] + s + s[s.Length - 1];
        }

        public static bool Or35(int n)
        {
            return n % 3 == 0 || n % 5 == 0;
        }

        public static string Front22(string s)
        {
            if (s.Length < 2)
            {
                return s + s + s;
            }
            else
            {
                string front = s.Substring(0, 2);
                return front + s + front;
            }
        }

        public static bool StartHi(string s)
        {
            return s.StartsWith("hi");
        }

        public static bool IcyHot(int t1, int t2)
        {
            return (t1 < 0 && t2 > 100) || (t1 > 100 && t2 < 0);
        }

        public static bool In1020(int a, int b)
        {
            return (a >= 10 && a <= 20) || (b >= 10 && b <= 20);
        }

        public static bool HasTen(int a, int b, int c)
        {
            return (a >= 13 && a <= 19) || (b >= 13 && b <= 19) || (c >= 13 && c <= 19);
        }

        public static bool IOneTeen(int a, int b)
        {
            return (a >= 13 && a <= 19 && (b < 13 || b > 19)) || (b >= 13 && b <= 19 && (a < 13 || a > 19));
        }

        public static string DelDel(string s)
        {
            if (s.Length >= 3 && s.Substring(1, 3) == "del")
            {
                return s.Remove(1, 3);
            }
            else
            {
                return s;
            }
        }

        public static bool MixStart(string s)
        {
            return (s.Length >= 3 && s[1] == 'i' && s[2] == 'x') ? true : false;
        }

        public static string StartOz(string s)
        {
            if (s.Length > 1)
            {
                if (s[0] == 'o' && s[1] != 'z')
                {
                    return "o";
                }
                else if (s[0] != 'o' && s[1] == 'z')
                {
                    return "z";
                }
                else
                {
                    return s.Substring(0, 2);
                }
            }
            else
            {
                return s;
            }
        }

        public static int intMax(int a, int b, int c)
        {
            if (a >= b)
            {
                if (a >= c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else if (b >= c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        public static int Close10(int a, int b)
        {
            if (Math.Abs(10 - a) < Math.Abs(10 - b))
            {
                return a;
            }
            else if (Math.Abs(10 - a) > Math.Abs(10 - b))
            {
                return b;
            }
            else
            {
                return 0;
            }
        }

        public static bool In3050(int a, int b)
        {
            return (a >= 30 && a <= 40 && b >= 30 && b <= 40) || (a >= 40 && a <= 50 && b >= 40 && b <= 50);
        }

        public static int Max1020(int a, int b)
        {
            if (a >= 10 && a <= 20 && b >= 10 && b <= 20)
            {
                if (a >= b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
            else if (a >= 10 && a <= 20)
            {
                return a;
            }
            else if (b >= 10 && b <= 20)
            {
                return b;
            }
            else
            {
                return 0;
            }
        }

        public static bool StringE(string s)
        {
            int e = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'e')
                {
                    e++;
                }
            }

            return e > 0 && e < 4;
        }

        public static bool LastDigit(int a, int b)
        {
            return Math.Abs(a % 10) == Math.Abs(b % 10);
        }

        public static string EndUp(string s)
        {
            return s.Length < 3 ? s.ToUpper() : s.Remove(s.Length - 3) + s.Substring(s.Length - 3).ToUpper();
        }

        public static string EveryNth(string s, int n)
        {
            return (s.Length - 1 >= n) ? s[0] + EveryNth(s.Remove(0, n), n) : s[0].ToString();
        }
    }
}
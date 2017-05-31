using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class String1
    {
        public static string HelloName(string name)
        {
            return "Hello " + name + "!";
        }

        public static string MakeAbba(string a, string b)
        {
            return a + b + b + a;
        }

        public static string MakeTags(string tag, string word)
        {
            return "<" + tag + ">" + word + "</" + tag + ">";
        }

        public static string MakeOutWord(string outs, string word)
        {
            return outs.Substring(0, 2) + word + outs.Substring(2);
        }

        public static string ExtraEnd(string s)
        {
            string last2 = s.Substring(s.Length - 2);
            return last2 + last2 + last2;
        }

        public static string FirstTwo(string s)
        {
            return s.Length < 2 ? s : s.Substring(0, 2);
        }

        public static string FirstHalf(string s)
        {
            return s.Substring(0, s.Length / 2);
        }

        public static string WithoutEnd(string s)
        {
            return s.Substring(1)
                .Substring(0, s.Length - 2);
        }

        public static string ComboString(string a, string b)
        {
            return a.Length < b.Length ? a + b + a : b + a + b;
        }

        public static string NonStart(string a, string b)
        {
            return a.Substring(1) + b.Substring(1);
        }

        public static string Left2(string s)
        {
            return s.Remove(0, 2) + s.Substring(0, 2);
        }

        public static string Right2(string s)
        {
            return s.Substring(s.Length - 2) + s.Remove(s.Length - 2);
        }

        public static string TheEnd(string s, bool front)
        {
            return front ? s.Substring(0, 1) : s.Substring(s.Length - 1);
        }

        public static string WithoutEnd2(string s)
        {
            return s.Length < 2 ? String.Empty : s.Substring(1, s.Length - 2);
        }

        public static string MiddleTwo(string s)
        {
            return s.Substring(s.Length / 2 - 1, 2);
        }

        public static bool EndsLy(string s)
        {
            return s.EndsWith("ly");
        }

        public static string NTwice(string s, int n)
        {
            return s.Substring(0, n) + s.Substring(s.Length - n);
        }

        public static string TwoChar(string s, int index)
        {
            return index + 2 <= s.Length ? s.Substring(index, 2) : s.Substring(0, 2);
        }

        public static string MiddleThree(string s)
        {
            return s.Substring((s.Length - 1) / 2 - 1, 3);
        }

        public static bool HasBad(string s)
        {
            if (s.Length > 3 && (String.Compare(s.Substring(0, 3), "bad") == 0
                || String.Compare(s.Substring(1, 3), "bad") == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string AtFirst(string s)
        {
            if (s.Length >= 2)
            {
                s = s.Substring(0, 2);
            }
            else if (s.Length > 0)
            {
                s = s.Substring(0, 1) + "@";
            }
            else
            {
                s = "@@";
            }

            return s;
        }

        public static string LastChars(string a, string b)
        {
            string lastChars = String.Empty;

            if (a.Length > 0)
            {
                lastChars += a.Substring(0, 1);
            }
            else
            {
                lastChars += "@";
            }

            if (b.Length > 0)
            {
                lastChars += b.Substring(b.Length - 1);
            }
            else
            {
                lastChars += "@";
            }

            return lastChars;
        }

        public static string Concat(string a, string b)
        {
            if (a.Length < 1)
            {
                return b;
            }

            if (b.Length < 1)
            {
                return a;
            }

            return !a.EndsWith(b.Substring(0, 1)) ? a + b : a + b.Substring(1);
        }

        public static string LastTwo(string s)
        {
            if (s.Length > 1)
            {
                return s.Substring(0, s.Length - 2) + s[s.Length - 1] + s[s.Length - 2];
            }
            else
            {
                return s;
            }
        }

        public static string SeeColors(string s)
        {
            if (s.StartsWith("red"))
            {
                return "red";
            }
            else if (s.StartsWith("blue"))
            {
                return "blue";
            }
            else
            {
                return String.Empty;
            }
        }

        public static bool FrontAgain(string s)
        {
            return s.Substring(0, 2) == s.Substring(s.Length - 2);
        }

        public static string MinCat(string a, string b)
        {
            if (a.Length < b.Length)
            {
                return a + b.Substring(b.Length - a.Length);
            }
            else if (a.Length > b.Length)
            {
                return a.Substring(a.Length - b.Length) + b;
            }
            else
            {
                return a + b;
            }
        }

        public static string ExtraFront(string s)
        {
            string extraFront = String.Empty;

            if (s.Length < 2)
            {
                return s + s + s;
            }
            else
            {
                extraFront = s.Substring(0, 2);
                return extraFront + extraFront + extraFront;
            }
        }

        public static string Without2(string s)
        {
            if (s.Length > 1 && s.Substring(0, 2) == s.Substring(s.Length - 2))
            {
                return s.Substring(2);
            }
            else
            {
                return s;
            }
        }

        public static string DeFront(string s)
        {
            if (s.Length >= 2)
            {
                if (String.Compare(s.Substring(1, 1), "b") != 0)
                {
                    s = s.Remove(1, 1);
                }

                if (String.Compare(s.Substring(0, 1), "a") != 0)
                {
                    s = s.Remove(0, 1);
                }
            }
            else if (s.Length > 0 && String.Compare(s.Substring(0, 1), "a") != 0)
            {
                s = s.Remove(0, 1);
            }

            return s;
        }

        public static string StartWord(string s, string word)
        {
            return String.Compare(s.Substring(1, word.Length - 1), word.Substring(1)) == 0 ? s.Substring(0, word.Length) : String.Empty;
        }

        public static string WithoutX(string s)
        {
            if (s.Length > 0 && s.Substring(s.Length - 1) == "x")
            {
                s = s.Remove(s.Length - 1);
            }

            if (s.Length > 0 && s.Substring(0, 1) == "x")
            {
                s = s.Remove(0, 1);
            }

            return s;
        }

        public static string WithoutX2(string s)
        {
            if (s.Length == 1 && s.Substring(0, 1) == "x")
            {
                s = s.Remove(0, 1);
            }

            if (s.Length > 1)
            {
                if (s.Substring(1, 1) == "x")
                {
                    s = s.Remove(1, 1);
                }

                if (s.Substring(0, 1) == "x")
                {
                    s = s.Remove(0, 1);
                }
            }

            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class String2
    {
        public static string DoubleChar(string str)
        {
            for (int i = 0; i < str.Length; i += 2)
            {
                str = str.Substring(0, i + 1) + str[i] + str.Substring(i + 1);
            }

            return str;
        }

        public static int CountHi(string str)
        {
            int count, i;
            count = i = 0;

            while (i < str.Length - 1)
            {
                if (str.Substring(i, 2) == "hi")
                {
                    count++;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }

            return count;
        }

        public static bool CatDog(string str)
        {
            int cat, dog, i;
            cat = dog = i = 0;

            while (i < str.Length - 2)
            {
                if (str.Substring(i, 3) == "cat")
                {
                    cat++;
                    i += 3;
                    continue;
                }
                if (str.Substring(i, 3) == "dog")
                {
                    dog++;
                    i += 3;
                    continue;
                }

                i++;
            }

            return cat == dog;
        }

        public static int CountCode(string str)
        {
            int count, i;
            count = i = 0;

            while (i < str.Length - 3)
            {
                if (str.Substring(i, 2).CompareTo("co") == 0
                    && str.Substring(i + 3, 1).CompareTo("e") == 0)
                {
                    count++;
                    i += 4;
                }
                else
                {
                    i++;
                }
            }

            return count;
        }

        public static bool EndOther(string a, string b)
        {
            //return a.ToLower().EndsWith(b.ToLower()) || b.ToLower().EndsWith(a.ToLower()); //no loops
            a = a.ToLower();
            b = b.ToLower();

            if (a.Length >= b.Length)
            {
                a = a.Substring(a.Length - b.Length);
            }
            else
            {
                b = b.Substring(b.Length - a.Length);
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool XYZThere(string str)
        {
            if (str.Length < 3) return false;

            if (str.Substring(0, 3).CompareTo("xyz") == 0)
            {
                return true;
            }

            for (int i = 1; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 3).CompareTo("xyz") == 0
                    && str.Substring(i - 1, 1).CompareTo(".") != 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool BobThere(string str)
        {
            while (str.Length >= 3)
            {
                if (str[str.Length - 3] == 'b' && str[str.Length - 1] == 'b') return true;
                str = str.Remove(str.Length - 1);
            }

            return false;
        }

        public static bool XYBalanced(string str)
        {
            bool xyBalanced = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'x')
                {
                    xyBalanced = false;
                }

                if (str[i] == 'y')
                {
                    xyBalanced = true;
                }
            }

            return xyBalanced;
        }

        public static string MixString(string a, string b)
        {
            string mixedString = String.Empty, smaller = String.Empty, bigger = String.Empty;
            int i = 0, j = 0;

            smaller = a.Length <= b.Length ? a : b;
            bigger = a.Length > b.Length ? a : b;

            while (i < smaller.Length)
            {
                mixedString += a.Substring(i++, 1);
                mixedString += b.Substring(j++, 1);
            }

            return mixedString += bigger.Substring(j);
        }

        public static string RepeatEnd(string str, int n)
        {
            string result = String.Empty;

            for (int i = 0; i < n; i++)
            {
                result += str.Substring(str.Length - n);
            }

            return result;
        }

        public static string RepeatFront(string str, int n)
        {
            string result = String.Empty;

            while (n > 0)
            {
                result += str.Substring(0, n--);
            }

            return result;
        }

        public static string RepeatSeparator(string word, string sep, int count)
        {
            string result = String.Empty;

            for (int i = 0; i < count; i++)
            {
                result += word + sep;
            }

            return result.Substring(0, result.Length - sep.Length);
        }

        public static bool PrefixAgain(string str, int n)
        {
            string prefix = str.Substring(0, n);
            str = str.Substring(n);

            for (int i = 0; i <= str.Length - n; i++)
            {
                if (str.Substring(i, n).CompareTo(prefix) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool XYZMiddle(string str)
        {
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 3).CompareTo("xyz") == 0)
                {
                    if (Math.Abs(3 + 2 * i - str.Length) <= 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static string GetSandwich(string str)
        {
            int i, j;
            int jump = "bread".Length;
            i = 0;
            j = str.Length - jump;
            bool first, last;

            first = last = false;

            if (str.Length >= 10)
            {
                while (i + jump < j && !first && !last)
                {
                    if (str.Substring(i, jump) != "bread" && !first)
                    {
                        i++;
                    }
                    else
                    {
                        first = true;
                    }

                    if (str.Substring(j, jump) != "bread" && !last)
                    {
                        j--;
                    }
                    else
                    {
                        last = true;
                    }
                }


            }

            return first && last ? str.Substring(i + jump, j - i - jump) : String.Empty;
        }

        public static bool SameStarChar(string str)
        {
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str[i] == '*' && str[i - 1] != str[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static string OneTwo(string str)
        {
            string result = String.Empty;

            for (int i = 0; i <= str.Length - 3; i += 3)
            {
                result += str.Substring(i + 1, 2) + str.Substring(i, 1);
            }

            return result;
        }

        public static string ZipZap(string str)
        {
            int i = 0;
            string zipzap = String.Empty;

            while (i < str.Length)
            {
                if (i <= str.Length - 3 && str.Substring(i, 1) == "z" && str.Substring(i + 2, 1) == "p")
                {
                    zipzap += str.Substring(i, 1) + str.Substring(i + 2, 1);
                    i += 3;
                }
                else
                {
                    zipzap += str.Substring(i++, 1);
                }
            }

            return zipzap;
        }

        public static string StarOut(string str)
        {
            string starOut = String.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (i > 0 && str.Substring(i - 1, 1) == "*") continue;
                else if (str.Substring(i, 1) == "*") continue;
                else if (i < str.Length - 1 && str.Substring(i + 1, 1) == "*") continue;
                else starOut += str.Substring(i, 1);
            }

            return starOut;
        }

        public static string PlusOut(string str, string word)
        {
            string plusOut = String.Empty;
            int i = 0;

            while (i < str.Length)
            {
                if (i + word.Length <= str.Length && str.Substring(i, word.Length) == word)
                {
                    plusOut += word;
                    i += word.Length;
                }
                else
                {
                    plusOut += "+";
                    i++;
                }
            }

            return plusOut;
        }

        public static string WordEnds(string str, string word)
        {
            string wordEnds = String.Empty;

            for (int i = 0; i + word.Length <= str.Length; i++)
            {
                if (str.Substring(i, word.Length) == word)
                {
                    if (i > 0) wordEnds += str.Substring(i - 1, 1);
                    if (i + word.Length < str.Length) wordEnds += str.Substring(i + word.Length, 1);
                }
            }

            return wordEnds;
        }
    }
}

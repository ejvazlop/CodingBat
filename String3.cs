using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class String3
    {
        public static int CountYZ(string str)
        {
            int count = 0;
            str = str.ToLower();

            for (int i = 1; i < str.Length; i++)
            {
                if (!Char.IsLetter(str[i])
                    && (str[i - 1].Equals('z') || str[i - 1].Equals('y')))
                {
                    count++;
                }
            }

            if (str.Substring(str.Length - 1, 1).Equals("z") || str.Substring(str.Length - 1, 1).Equals("y"))
            {
                count++;
            }

            return count;
        }

        public static string WithoutString(string baseString, string removeString)
        {
            string withoutString = String.Empty;
            removeString = removeString.ToLower();

            int i = 0;

            while (i < baseString.Length)
            {
                if (i + removeString.Length > baseString.Length)
                {
                    withoutString += baseString.Substring(i);
                    i += removeString.Length;
                }
                else if (baseString.Substring(i, removeString.Length).ToLower().Equals(removeString))
                {
                    i += removeString.Length;
                }
                else
                {
                    withoutString += baseString.Substring(i, 1);
                    i++;
                }
            }

            return withoutString;
        }

        public static bool EqualIsNot(string str)
        {
            int countIs = 0, countNot = 0, i = 0;

            while (i + "not".Length <= str.Length)
            {
                if (str.Substring(i, "is".Length).Equals("is"))
                {
                    countIs++;
                    i += 2;
                }
                else if (str.Substring(i, "not".Length).Equals("not"))
                {
                    countNot++;
                    i += 3;
                }
                else i++;
            }

            if (i < str.Length - 1 && str.Substring(i, 2).Equals("is")) countIs++;

            return countIs == countNot;
        }

        public static bool GHappy(string str)
        {
            bool gHappy = true;
            int len = str.Length;

            if (len == 0) return true;
            if (len == 1) return false;

            if ((str[0] == 'g' && str[1] != 'g')
                || (str[len - 1] == 'g' && str[len - 2] != 'g')) gHappy = false;

            for (int i = 1; i < len - 1; i++)
            {
                if (str[i] == 'g' && str[i - 1] != 'g' && str[i + 1] != 'g')
                {
                    gHappy = false;
                }
            }

            return gHappy;
        }

        public static int CountTriple(string str)
        {
            int triple = 0;

            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str[i] == str[i + 1] && str[i] == str[i + 2])
                {
                    triple++;
                }
            }

            return triple;
        }

        public static int SumDigits(string str)
        {
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (Char.IsDigit(c))
                {
                    sum += c - '0';
                }
            }

            return sum;
        }

        public static string SameEnds(string str)
        {
            int len = str.Length;

            for (int i = len / 2; i >= 0; i--)
            {
                string sub = str.Substring(0, i);

                if (String.Compare(sub, str.Substring(len - i)) == 0)
                {
                    return sub;
                }
            }

            return String.Empty;
        }
        public static string MirrorEnds(string str)
        {
            string mirrorEnds = String.Empty;

            for (int i = 0; i < str.Length && str[i] == str[str.Length - 1 - i]; i++)
            {
                mirrorEnds = str.Substring(0, i + 1);
            }

            return mirrorEnds;
        }

        public static int MaxBlock(string s)
        {
            int max = 0;

            for (int i = 0; s.Length - i > max; i++)
            {
                int nblock = 0;

                for (int j = i; j < s.Length && s[i] == s[j]; j++)
                {
                    if (++nblock > max)
                    {
                        max = nblock;
                    }
                }
            }

            return max;
        }

        public static int SumNumbers(string str)
        {
            int sum = 0, len = str.Length;
            string number = String.Empty;

            for (int i = 0; i < len; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    number += str[i] - '0';

                    if (len == i + 1)
                    {
                        sum += int.Parse(number);
                    }
                }
                else if (number.Length > 0)
                {
                    sum += int.Parse(number);
                    number = String.Empty;
                }
            }

            return sum;
        }

        public static string NotReplace(string str)
        {
            string notReplace = String.Empty;
            int len = str.Length;

            for (int i = 0; i < len; i++)
            {
                if ((i < 1 && str.Substring(i, 2) == "is" && !Char.IsLetter(str[i + 2]))
                    || (i + 2 < len && str.Substring(i, 2) == "is" && !Char.IsLetter(str[i + 2]) && !Char.IsLetter(str[i - 1]))
                    || (i + 2 == len && str.Substring(i, 2) == "is" && !Char.IsLetter(str[i - 1]))
                    )
                {
                    notReplace += "is not";
                    i++;
                }
                else
                {
                    notReplace += str.Substring(i, 1);
                }
            }

            return notReplace;
        }
    }
}

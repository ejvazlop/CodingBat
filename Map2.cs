using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class Map2
    {
        public static Dictionary<string, int> Word0(string[] strings)
        {
            Dictionary<string, int> word0 = new Dictionary<string, int>();

            for (int i = 0; i < strings.Length; i++)
            {
                if (!word0.ContainsKey(strings[i]))
                {
                    word0.Add(strings[i], 0);
                }
            }

            return word0;
        }

        public static Dictionary<string, int> WordLen(string[] strings)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < strings.Length; i++)
            {
                if (!result.ContainsKey(strings[i]))
                {
                    result.Add(strings[i], strings[i].Length);
                }
            }

            return result;
        }

        public static Dictionary<string, string> Pairs(string[] strings)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();

            for (int i = 0; i < strings.Length; i++)
            {
                if (!pairs.ContainsKey(strings[i].Substring(0, 1)))
                {
                    pairs.Add(strings[i].Substring(0, 1), strings[i].Substring(strings[i].Length - 1));
                }
            }

            return pairs;
        }

        public static Dictionary<string, int> WordCount(string[] strings)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            for (int i = 0; i < strings.Length; i++)
            {
                if (wordCount.ContainsKey(strings[i])) wordCount[strings[i]] += 1;
                else wordCount.Add(strings[i], 1);
            }

            return wordCount;
        }

        public static Dictionary<string, string> FirstChar(string[] strings)
        {
            Dictionary<string, string> firstChars = new Dictionary<string, string>();

            for (int i = 0; i < strings.Length; i++)
            {
                string first = strings[i].Substring(0, 1);
                if (firstChars.ContainsKey(first)) firstChars[first] += strings[i];
                else firstChars.Add(first, strings[i]);
            }

            return firstChars;
        }

        public static string WordAppend(string[] strings)
        {
            Dictionary<string, int> chars = new Dictionary<string, int>();
            string s = String.Empty;

            for (int i = 0; i < strings.Length; i++)
            {
                if (chars.ContainsKey(strings[i]))
                {
                    chars[strings[i]] += 1;

                    if (chars[strings[i]] % 2 == 0) s += strings[i];
                }
                else chars.Add(strings[i], 1);
            }

            return s;
        }

        public static Dictionary<string, bool> WordMultiple(string[] strings)
        {
            Dictionary<string, bool> words = new Dictionary<string, bool>();

            for (int i = 0; i < strings.Length; i++)
            {
                if (words.ContainsKey(strings[i])) words[strings[i]] = true;
                else words.Add(strings[i], false);
            }

            return words;
        }

        public static string[] AllSwap(string[] strings)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            for (int i = 0; i < strings.Length; i++)
            {
                string firstChar = strings[i].Substring(0, 1), temp = String.Empty;

                if (map.ContainsKey(firstChar))
                {
                    if (map[firstChar] >= 0)
                    {
                        temp = strings[i];
                        strings[i] = strings[map[firstChar]];
                        strings[map[firstChar]] = temp;
                        map[firstChar] = -1;
                    }
                    else
                    {
                        map[firstChar] = i;
                    }
                }
                else
                {
                    map.Add(firstChar, i);
                }
            }

            return strings;
        }

        public static string[] FirstSwap(string[] strings)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            for (int i = 0; i < strings.Length; i++)
            {
                string firstChar = strings[i].Substring(0, 1), temp = String.Empty;

                if (map.ContainsKey(firstChar))
                {
                    if (map[firstChar] >= 0)
                    {
                        temp = strings[i];
                        strings[i] = strings[map[firstChar]];
                        strings[map[firstChar]] = temp;
                        map[firstChar] = -1;
                    }
                }
                else
                {
                    map.Add(firstChar, i);
                }
            }

            return strings;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class AP1
    {
        public static bool ScoresIncreasing(int[] scores)
        {
            for (int i = 0; i < scores.Length - 1; i++)
            {
                if (scores[i + 1] < scores[i]) return false;
            }

            return true;
        }

        public static bool Scores100(int[] scores)
        {
            for (int i = 0; i < scores.Length - 1; i++)
            {
                if (scores[i + 1] == scores[i] && scores[i] == 100) return true;
            }

            return false;
        }

        public static bool ScoresClump(int[] scores)
        {
            for (int i = 0; i <= scores.Length - 3; i++)
            {
                if (scores[i + 2] - scores[i] <= 2) return true;
            }

            return false;
        }

        public static int ScoresAverage(int[] scores)
        {
            return Math.Max(AP1Helper.Average(scores, 0, (scores.Length / 2)),
                            AP1Helper.Average(scores, scores.Length / 2, scores.Length));
        }

        public static int WordsCount(string[] words, int len)
        {
            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == len) count++;
            }

            return count;
        }

        public static string[] WordsFront(string[] words, int n)
        {
            string[] front = new string[n];

            for (int i = 0; i < n; i++)
            {
                front[i] = words[i];
            }

            return front;
        }

        public static ArrayList WordsWithoutList(string[] words, int len)
        {
            ArrayList wordsWithout = new ArrayList();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == len)
                {
                    wordsWithout.Add(words[i]);
                }
            }

            return wordsWithout;
        }

        public static bool HasOne(int n)
        {
            while (n > 0)
            {
                if (n % 10 == 1) return true;
                n /= 10;
            }

            return false;
        }

        public static bool DividesSelf(int n)
        {
            int m = n;
            while (m > 0)
            {
                int mod = m % 10;
                if (mod == 0 || n % mod > 0) return false;
                m /= 10;
            }

            return true;
        }

        public static int[] CopyEvens(int[] nums, int count)
        {
            int[] evens = new int[count];
            int j = 0;

            for (int i = 0; j < count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evens[j] = nums[i];
                    j++;
                }
            }

            return evens;
        }

        public static int[] CopyEndy(int[] nums, int count)
        {
            int[] endy = new int[count];
            int j = 0;

            for (int i = 0; j < count; i++)
            {
                if (AP1Helper.IsEndy(nums[i]))
                {
                    endy[j] = nums[i];
                    j++;
                }
            }

            return endy;
        }

        public static int MatchUp(string[] a, string[] b)
        {
            int matchs = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length > 0 && b[i].Length > 0 && a[i][0] == b[i][0]) matchs++;
            }

            return matchs;
        }

        public static int ScoreUp(string[] key, string[] answers)
        {
            int score = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == key[i]) score += 4;
                if (answers[i] != key[i] && answers[i] != "?") score += -1;
            }

            return score;
        }

        public static string[] WordsWithout(string[] words, string target)
        {
            int capacity = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != target)
                {
                    capacity++;
                }
            }

            string[] wordsWithout = new string[capacity];

            for (int i = 0, j = 0; i < words.Length; i++)
            {
                if (words[i] != target)
                {
                    wordsWithout[j++] = words[i];
                }
            }

            return wordsWithout;
        }
        public static int ScoresSpecial(int[] a, int[] b)
        {
            return AP1Helper.LargestSpecial(a) + AP1Helper.LargestSpecial(b);
        }

        public static int SumHeights(int[] heights, int start, int end)
        {
            int sum = 0;

            while (end > start)
            {
                sum += Math.Abs(heights[end] - heights[end - 1]);
                end--;
            }

            return sum;
        }

        public static int SumHeights2(int[] heights, int start, int end)
        {
            int sum = 0;

            while (end > start)
            {
                sum += heights[end] > heights[end - 1] ? 2 * Math.Abs(heights[end] - heights[end - 1]) : Math.Abs(heights[end] - heights[end - 1]);
                end--;
            }

            return sum;
        }

        public static int BigHeights(int[] heights, int start, int end)
        {
            int count = 0;

            while (end > start)
            {
                if (Math.Abs(heights[end] - heights[end - 1]) >= 5) count++;
                end--;
            }

            return count;
        }

        public static int UserCompare(string aName, int aId, string bName, int bId)
        {
            if (aName.CompareTo(bName) < 0) return -1;
            else if (aName.CompareTo(bName) > 0) return 1;
            else if (aId < bId) return -1;
            else if (aId > bId) return 1;
            else return 0;
        }

        public static string[] MergeTwo(string[] a, string[] b, int n)
        {
            string[] c = new string[n];
            int x = 0, y = 0;

            for (int i = 0; i < n; i++)
            {
                if (a[x].CompareTo(b[y]) < 0)
                {
                    c[i] = a[x];
                    x++;
                }
                else if (a[x].CompareTo(b[y]) > 0)
                {
                    c[i] = b[y];
                    y++;
                }
                else
                {
                    c[i] = a[x++];
                    y++;
                }
            }

            return c;
        }

        public static int CommonTwo(string[] a, string[] b)
        {
            int common = 0, x = 0, y = 0;

            while (x < a.Length && y < b.Length)
            {
                if ((x + 1 < a.Length && a[x] == a[x + 1]) || a[x].CompareTo(b[y]) < 0) x++;
                else if ((y + 1 < b.Length && b[y] == b[y + 1]) || a[x].CompareTo(b[y]) > 0) y++;
                else if (a[x].CompareTo(b[y]) == 0)
                {
                    x++; y++; common++;
                }
            }

            return common;
        }
    }
}

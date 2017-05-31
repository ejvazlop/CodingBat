using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class Functional2
    {
        public static List<int> NoNeg(List<int> nums)
        {
            return nums.Where(n => n >= 0).ToList();
        }

        public static List<int> No9(List<int> nums)
        {
            return nums.Where(n => n % 10 < 9).ToList();
        }

        public static List<int> NoTeen(List<int> nums)
        {
            return nums.Where(n => n < 13 || n > 19).ToList();
        }

        public static List<string> NoLong(List<string> strings)
        {
            return strings.Where(s => s.Length < 4).ToList();
        }

        public static List<string> NoZ(List<string> strings)
        {
            return strings.Where(s => !s.Contains("z")).ToList();
        }

        public static List<string> No34(List<string> strings)
        {
            return strings.Where(s => s.Length != 3 && s.Length != 4).ToList();
        }

        public static List<string> NoYY(List<string> strings)
        {
            return strings.Select<string, string>(s => s + "y")
                .Where(r => !r.EndsWith("yy"))
                .ToList();
        }

        public static List<int> Two2(List<int> nums)
        {
            return nums.Select(n => n * 2)
                .Where(x => x % 10 != 2)
                .ToList();
        }

        public static List<int> Squared56(List<int> nums)
        {
            return nums.Select(n => 10 + (n * n))
                .Where(x => x % 10 != 5 && x % 10 != 6)
                .ToList();
        }
    }
}

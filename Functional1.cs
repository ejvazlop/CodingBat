using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class Functional1
    {
        public static List<int> Doubling(List<int> nums)
        {
            IEnumerable<int> doubled = nums.Select(x => x *= 2);
            return doubled.ToList<int>();
        }

        public static List<int> Square(List<int> nums)
        {
            IEnumerable<int> squared = nums.Select(x => x *= x);
            return squared.ToList();
        }

        public static List<string> AddStar(List<string> strings)
        {
            IEnumerable<string> s = strings.Select(x => x + "*");
            return s.ToList();
        }

        public static List<string> Copies3(List<string> strings)
        {
            IEnumerable<string> s = strings.Select(x => x = x + x + x);
            return s.ToList();
        }

        public static List<string> MoreY(List<string> strings)
        {
            IEnumerable<string> s = strings.Select(x => "y" + x + "y");
            return s.ToList();
        }

        public static List<int> Math1(List<int> nums)
        {
            IEnumerable<int> e = nums.Select(x => 10 * (x + 1));
            return e.ToList();
        }

        public static List<int> RightDigit(List<int> nums)
        {
            IEnumerable<int> digits = nums.Select(x => x % 10);
            return digits.ToList();
        }

        public static List<string> Lower(List<string> strings)
        {
            IEnumerable<string> s = strings.Select(x => x.ToLower());
            return s.ToList();
        }

        public static List<string> NoX(List<string> strings)
        {
            return strings.Select(x => x.Replace("x", "")).ToList();
        }
    }
}

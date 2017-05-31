using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class Logic1
    {
        public static bool CigarParty(int cigars, bool isWeekend)
        {
            return (!isWeekend && cigars >= 40 && cigars <= 60)
                || (isWeekend && cigars >= 40);
        }

        public static int DateFashion(int you, int date)
        {
            if (you <= 2 || date <= 2)
            {
                return 0;
            }
            else if (you >= 8 || date >= 8)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public static bool SquirrelPlay(int temp, bool isSummer)
        {
            return (temp >= 60 && temp <= 90 && !isSummer)
                || (isSummer && temp >= 60 && temp <= 100) ? true : false;
        }

        public static int CaughtSpeeding(int speed, bool isBirthday)
        {
            int extraSpeed = 0;

            if (isBirthday)
            {
                extraSpeed += 5;
            }

            if (speed <= 60 + extraSpeed)
            {
                return 0;
            }
            else if (speed >= 61 && speed <= 80 + extraSpeed)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public static int SortaSum(int a, int b)
        {
            return a + b >= 10 && a + b < 20 ? 20 : a + b;
        }

        public static string AlarmClock(int day, bool vacation)
        {
            bool weekEnd = day >= 1 && day <= 5 ? false : true;

            if (!vacation && !weekEnd)
            {
                return "7:00";
            }
            else if ((!vacation && weekEnd) || (vacation && !weekEnd))
            {
                return "10:00";
            }
            else
            {
                return String.Empty;
            }
        }

        public static bool Love6(int a, int b)
        {
            return a == 6 || b == 6 || Math.Abs(a + b) == 6 || Math.Abs(a - b) == 6 ? true : false;
        }

        public static bool In1To10(int n, bool outsideMode)
        {
            return ((!outsideMode && n >= 1 && n <= 10)
                || outsideMode && (n < 1 || n > 10));
        }

        public static bool SpecialEleven(int n)
        {
            return n % 11 == 0 || n % 11 == 1;
        }

        public static bool More20(int n)
        {
            return n % 20 == 1 || n % 20 == 2;
        }

        public static bool Old35(int n)
        {
            return n % 3 == 0 ^ n % 5 == 0;
        }

        public static bool Less20(int n)
        {
            return n % 20 == 19 || n % 20 == 18;
        }

        public static bool NearTen(int n)
        {
            return n % 10 <= 2 || n % 10 >= 8;
        }
        public static int TeenSum(int a, int b)
        {
            return (a >= 13 && a <= 19) || (b >= 13 && b <= 19) ? 19 : a + b;
        }

        public static bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            return (isAsleep || isMorning && !isMom) ? false : true;
        }

        public static int TeaParty(int tea, int candy)
        {
            if (tea >= 5 && candy >= 5 && (tea >= candy * 2 || candy >= tea * 2))
            {
                return 2;
            }
            else if (tea >= 5 && candy >= 5)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static string FizzString(string s)
        {
            if (s.StartsWith("f") && s.EndsWith("b"))
            {
                return "FizzBuzz";
            }
            else if (s.StartsWith("f"))
            {
                return "Fizz";
            }
            else if (s.EndsWith("b"))
            {
                return "Buzz";
            }
            else
            {
                return String.Empty;
            }
        }

        public static string FizzString2(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                return "FizzBuzz!";
            }
            else if (n % 3 == 0)
            {
                return "Fizz!";
            }
            else if (n % 5 == 0)
            {
                return "Buzz!";
            }
            else
            {
                return n + "!";
            }
        }

        public static bool TwoAsOne(int a, int b, int c)
        {
            return a == b + c || b == a + c || c == a + b;
        }

        public static bool InOrder(int a, int b, int c, bool bOk)
        {
            return bOk ? a < c : a < b && b < c;
        }

        public static bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            return equalOk ? a <= b && b <= c : a < b && b < c;
        }

        public static bool LastDigit(int a, int b, int c)
        {
            return a % 10 == b % 10 || a % 10 == c % 10 || b % 10 == c % 10;
        }

        public static bool LessBy10(int a, int b, int c)
        {
            return Math.Abs(a - b) >= 10 || Math.Abs(a - c) >= 10 ||
                   Math.Abs(b - c) >= 10;
        }

        public static int WithoutDoubles(int die1, int die2, bool noDoubles)
        {
            return noDoubles && die1 == die2 ? die1 % 6 + die2 + 1 : die1 + die2;
        }

        public static int MaxMod5(int a, int b)
        {
            if (a == b)
            {
                return 0;
            }
            else if ((a % 5 == b % 5 && a < b) || a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static int RedTicket(int a, int b, int c)
        {
            if (a == 2 && a == b && b == c)
            {
                return 10;
            }
            else if (a == b && b == c)
            {
                return 5;
            }
            else if (a != b && b != c)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int GreenTicket(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return 20;
            }
            else if (a == b || a == c || b == c)
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }

        public static int BlueTicket(int a, int b, int c)
        {
            if (a + b == 10 || a + c == 10 || b + c == 10) return 10;
            if (a + b == 10 + a + c || a + b == 10 + b + c) return 5;
            return 0;
        }

        public static bool ShareDigit(int a, int b)
        {
            return a / 10 == b / 10 || a / 10 == b % 10 || a % 10 == b / 10 || a % 10 == b % 10;
        }

        public static int SumLimit(int a, int b)
        {
            return (a + b).ToString().Length > a.ToString().Length ? a : a + b;
        }
    }
}

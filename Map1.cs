using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBat
{
    class Map1
    {
        public static Dictionary<string, string> MapBully(Dictionary<string, string> map)
        {
            if (!String.IsNullOrEmpty(map["a"]))
            {
                map["b"] = map["a"];
                map["a"] = String.Empty;
            }

            return map;
        }

        public static Dictionary<string, string> MapShare(Dictionary<string, string> map)
        {
            map.Remove("c");
            if (!String.IsNullOrEmpty(map["a"])) map["b"] = map["a"];
            return map;
        }

        public static Dictionary<string, string> MapAB(Dictionary<string, string> map)
        {
            if (map.ContainsKey("a") && map.ContainsKey("b")) map.Add("ab", map["a"] + map["b"]);
            return map;
        }

        public static Dictionary<string, string> Topping1(Dictionary<string, string> map)
        {
            if (map.ContainsKey("ice cream")) map["ice cream"] = "cherry";
            map["bread"] = "butter";
            return map;
        }

        public static Dictionary<string, string> Topping2(Dictionary<string, string> map)
        {
            if (map.ContainsKey("ice cream")) map["yogurt"] = map["ice cream"];
            if (map.ContainsKey("spinach")) map["spinach"] = map["nuts"];
            return map;
        }

        public static Dictionary<string, string> Topping3(Dictionary<string, string> map)
        {
            if (map.ContainsKey("potato")) map["fries"] = map["potato"];
            if (map.ContainsKey("salad")) map["spinach"] = map["salad"];
            return map;
        }

        public static Dictionary<string, string> MapAB2(Dictionary<string, string> map)
        {
            if (map.ContainsKey("a") && map.ContainsKey("b") && map["a"].CompareTo(map["b"]) == 0) { map.Remove("a"); map.Remove("b"); }
            return map;
        }

        public static Dictionary<string, string> MapAB3(Dictionary<string, string> map)
        {
            if (map.ContainsKey("a") && !map.ContainsKey("b")) map["b"] = map["a"];
            if (map.ContainsKey("b") && !map.ContainsKey("a")) map["a"] = map["b"];
            return map;
        }

        public static Dictionary<string, string> MapAB4(Dictionary<string, string> map)
        {
            if (map.ContainsKey("a") && map.ContainsKey("b"))
            {
                if (map["a"].Length == map["b"].Length)
                {
                    map["a"] = String.Empty;
                    map["b"] = String.Empty;
                }
                else if (map["a"].Length > map["b"].Length)
                {
                    map["c"] = map["a"];
                }
                else
                {
                    map["c"] = map["b"];
                }
            }

            return map;
        }
    }
}

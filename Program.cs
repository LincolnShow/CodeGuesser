using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static readonly int LEN = 3;

        public static int GetCharDuplicatesCount(string s1, string s2)
        {
            int result = 0;

            int limit = s1.Length >= s2.Length ? s2.Length : s1.Length;
            for (int i = 0; i < limit; ++i)
            {
                if (s1[i] == s2[i])
                {
                    ++result;
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            /*Dictionary<string, int> input = new Dictionary<string, int>()
            {
                {"0677", 0},
                {"1157", 0},
                {"2644", 1},
                {"4293", 0},
                {"5410", 0},
                {"2554", 1},
                {"4781", 0},
                {"5266", 0},
                {"8330", 1},
                {"4877", 1},
                {"5210", 0},
                {"4030", 1},
                {"5407", 0},
                {"9624", 1},
                {"3059", 0},
                {"3151", 0},
                {"4829", 1},
                {"7963", 1}
            };*/

            Dictionary<string, int> input = new Dictionary<string, int>()
            {
                {"402", 0},
                {"390", 0},
                {"816", 2},
                {"848", 2},
                {"777", 0},
                {"815", 1}
            };

            if (input.ContainsValue(LEN))
            {
                Console.WriteLine(input.First(e => e.Value==LEN));
                return;
            }

            List<char>[] possible = new List<char>[LEN];
            for (int i = 0; i < LEN; ++i)
            {
                possible[i] = new List<char> {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            }


            foreach (KeyValuePair<string, int> entry in input)
            {
                // Gathering not possible values
                if (entry.Value == 0)
                {
                    string val = entry.Key;
                    for (int i = 0; i < LEN; ++i)
                    {
                        possible[i].Remove(val[i]);
                    }
                }
            }

            Dictionary<string, int> nonZero = input.Where(e => e.Value != 0).ToDictionary(e => e.Key, e => e.Value);

            SortedDictionary<char, int>[] candidates = new SortedDictionary<char, int>[LEN];
            for (int i = 0; i < LEN; ++i)
            {
                candidates[i] = new SortedDictionary<char, int>();
            }

            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> entry in nonZero)
            {
                foreach (KeyValuePair<string, int> entry2 in nonZero)
                {
                    if (!entry.Key.Equals(entry2.Key))
                    {
                        if(Get)
                    }
                }
            }

            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace CodeWars
{
    public class sevenKyu1
    {

        public static int[] minMax(int[] lst)
        {
            int[] MM = new int[2];
            MM[0] = lst.Min();
            MM[1] = lst.Max();
            
            return MM;
        }
        //Scaling Squared Strings
        public static string Scale(string strng, int k, int n)
        {
            
            string a = "";
            string b = "";
            StringBuilder newWord = new StringBuilder();
            
            
            for (int i = 0; i < strng.Length; i++)
            {
                for (int u = 0; u < k; u++)
                {
                 newWord.Insert(u, strng.Substring(i, 1));
                }

                
            }
            
            String[] wordList = newWord.ToString().Split('\n');
             for (int y = 0; y < wordList.Length; y++)
            {
                for (int t = 0; t < n; t++)
                {
                    a.Insert(y, "O");
                }
            }

             foreach (var val in wordList)
            { Console.Write(val); }
            return null;
        }

        public static string PrinterError(String s)
        {
            int counter = 0;
            int divisor = 0;
            char[] list = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm' };
            foreach (char c in s)
            {
                if(!list.Contains(c))
                {
                    divisor++;
                }

                counter++;
            }
            return divisor + "/" + counter;
        }
        //Disemvowel Trolls
        public static string Disemvowel(string str)
        {
            string[] vowels = { "a", "e", "i", "o", "u" };
            str = str.Insert(0, "i");
            for (int y=0; y < str.Length; y++ )
            {
                string v = str[y].ToString();
                
                if(vowels.Contains(v.ToLower()))
                {
                   str = str.Replace(v, "");
                    
                }
            }

            return str;
        }
        //Sexy Primes <3
        public static bool SexyPrime(int x, int y)
        {
            if (Math.Abs(x-y) == 6) 
            {
                return true;
            }
            return false;
        }
        //JavaScript Array Filter
        public static int[] GetEvenNumbers(int[] numbers)
        {
            IEnumerable<int> filter = numbers.Where(number => number%2 == 0);
            int[] newIntArr = { filter.Count()};
            foreach (int number in filter)
            {
                newIntArr.Append(number);
            }
            return newIntArr;
        }
        //Vowel Count
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            string[] vowels = { "a", "e", "i", "o", "u" };

            for (int y = 0; y < str.Length; y++)
            {
                string v = str[y].ToString();

                if (vowels.Contains(v.ToLower()))
                {
                    vowelCount++;

                }
            }
            //return str.Count(i => "aeiou".Contains(i));
            return vowelCount;
        }
        //The Office II - Boredom Score
        public static string Boredom(Dictionary<string, string> staff)
        {
            int cumulativeScore = 0;

            for (int i = 0; i < staff.Count(); i++)
            {
                String num = staff[staff.Keys.ElementAt(i)];

                switch (num)
                {
                    case "accounts":
                        cumulativeScore += 1;
                        break;
                    case "finance":
                        cumulativeScore += 2;
                        break;
                    case "canteen":
                        cumulativeScore += 10;
                        break;
                    case "regulation":
                        cumulativeScore += 3;
                        break;
                    case "trading":
                        cumulativeScore += 6;
                        break;
                    case "change":
                        cumulativeScore += 6;
                        break;
                    case "IS":
                        cumulativeScore += 8;
                        break;
                    case "retail":
                        cumulativeScore += 5;
                        break;
                    case "cleaning":
                        cumulativeScore += 4;
                        break;
                    case "pissing about":
                        cumulativeScore += 25;
                        break;
                }
            }
            string result = "party time!!";    
            if (cumulativeScore <= 80)
            {
                result = "kill me now";
            }
            else if (cumulativeScore < 100 && cumulativeScore > 80)
            {
                result = "i can handle this";
            }
            return result;
            /*
              private static Dictionary<string, int> _stuff = new Dictionary<string, int>
             { { "accounts", 1 }, { "finance" , 2 }, { "canteen" , 10 }, { "regulation" , 3 }, { "trading" , 6 }, { "change" , 6 }, { "IS" ,8 }, { "retail" , 5 }, { "cleaning" , 4 }, { "pissing about" , 25 } };
  
             public static string Boredom(Dictionary<string, string> staff)
             {
             int value = staff.Sum(x => _stuff[x.Value]);
                return (value <= 80) ? "kill me now" : (value < 100) ? "i can handle this" : "party time!!";
             } 
            */

        }
        //Power of two (not solved)
        public static bool PowerOfTwo(int n)
        {
            return n % 2 == 0 ? true : false;

        }

        //Ordere count of characters
        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            List<Tuple<char, int>> result = new List<Tuple<char, int>>();
            int letterCounter = 0;
            foreach (char letter in input)
            {
                letterCounter = input.Where(c => c == letter).Count();
                
                //letterCounter= letter.ToString().Count();
                result.Add(new Tuple<char, int>(letter, letterCounter));
            }

            return result.Distinct().ToList();

           // return input
           //.GroupBy(x => x)
           //.Select(x => Tuple.Create(x.Key, x.Count()))
           //.ToList();
        }

        //Friend or Foe?
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            IEnumerable<string> result = new string[] { };
            foreach (string name in names)
            {
                if (name.Length == 4)
                {
                    result = result.Concat(new[] { name});
                    /*IEnumerable<string> stringcol = new IEnumerable<string>();
                    stringcol = stringcol.Concat(new[] { "foo" }); */
                }
            }
            return result;

        }
        //Unlucky Days
        public static int UnluckyDays(int year)
        {
            DateTime startDate = new DateTime(year, 1, 1);
            DateTime endDate = new DateTime(year, 12, 31);
            DateTime counterDate = startDate;
            int counter = 1;
            int DayCounter = 0;
            while (counterDate <= endDate)
            {
                if(counterDate.DayOfWeek.Equals(5) && counterDate.Date.Equals(13))
                {
                    DayCounter++;
                    Console.WriteLine(DayCounter);
                }
                counterDate = startDate.Date.AddDays(counter);
                counter++;
            }
                      
            return DayCounter;
        }
        //Build a square
        public static string GenerateShape(int n)
        {
            StringBuilder oneLine = new StringBuilder("");
            StringBuilder result = new StringBuilder("");
            for (int i =0; i < n; i++)
            {
                oneLine.Append("+");
            }
            for (int i = 0; i < n; i++)
            {
                result.Append(oneLine + "\n");
            }

            return result.ToString().Trim();
        }
        //Count by X
        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];
            int num = 0;
            for (int i =0; i < n; i++)
            {
                num = num +x;
                z[i]=num;
            }
            // return Enumerable.Range(1, n).Select(i => i * x).ToArray();    
            return z;
        }

        //Sum of two lowest positive integers
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers[0] + numbers[1];
            //return numbers.OrderBy(i => i).Take(2).Sum();
        }

        public static int DescendingOrder(int num)
        {
            string strNum = Convert.ToString(num);
            int[] list = new int[num.ToString().Length];
            string temp = "";
            foreach (char l in strNum)
            {
                int bar = l - '0';
                list.Append(bar);
                
            }
            Array.Sort(list);
            Console.WriteLine((string.Concat((list))));
            return num;
        }

    }
}

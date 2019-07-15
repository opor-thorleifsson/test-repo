using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class eightKyu
    {
        
        public static bool IsLockNessMonster(string sentence)
        {
            // FIND THE LOCH NESS MONSTER. SAVE YOUR TREE FIDDY
            

            if (sentence.ToLower().Contains("tree fiddy") || sentence.ToLower().Contains("3.50") || sentence.ToLower().Contains(" three fifty"))
            {
                return true;

            }

            return false;
        }

        public static string nospace(string input)
        {
            return input.Replace(" ", "");
        }

        public static string toString(int input)
        {
            return input.ToString();
        }

        //Convert a String to a Number!
        public static int StringToNumber(String str)
        {
            return int.Parse(str);
        }

        //Remove First and Last Character
        public static string Remove_char(string s)
        {
            String firstL = s.Remove(0, 1).Remove(s.Length-2);
            
            return firstL;
        }

        public static int SumMix(object[] x)
        {
            int result = 0;
            for (int i=0; i< x.Length; i++)
            {
                if(x[i] is string)
                {
                    
                    string s = (string)x[i];
                    int num = int.Parse(s);
                    result += num;
                    
                }
                else if (x[i] is int)
                {

                    int n = (int)x[i];
                    int num2 = n;
                    result += num2;
                }
            }

            return result;
        }

        //The Feast of Many Beasts
        public static bool Feast(string beast, string dish)
        {
            if (beast.Substring(0, 1) == dish.Substring(0, 1) && beast.Substring(beast.Length-1, 1) == dish.Substring(dish.Length-1, 1))
            {
                return true;
            }

            return false;
        }

        //Are You Playing Banjo?
        public static string AreYouPlayingBanjo(string name)
        {
            string text = " plays banjo";
            string text2 = " does not play banjo";
            if (name.Substring(0,1).Equals("r", StringComparison.InvariantCultureIgnoreCase))
            {
                
                return name + text;
            }

            return name + text2;
        }
        //Reverse List Order
        public static List<int> ReverseList(List<int> list)
        {
            List<int> newList = new List<int>();
            int i = 0;
            while(i< list.Count)
            {
                newList.Add(list[list.Count-1-i]);
                i++;
            }

            return newList;
        }
        //Keep Hydrated!
        public static int Litres(double time)
        {
            //The fun begins here.

            int result = (int)Math.Floor(time / 2);
            return result;
        }
        //Removing Elements Not solved
        public static object[] RemoveEveryOther(object[] arr)
        {
            object[] list = new object[arr.Length];
            

            for (int i = 1; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    list.Append(arr[i].ToString());
                }

            }
            
            return list;
        }
        //Even or Odd
        public static string EvenOrOdd(int number)
        {
            if(number%2 ==0)
            {
                return "Even";
            }

            return "Odd";
        }
        public static string Greet(string name, string owner)
        {
            if (name.Equals(owner, StringComparison.InvariantCultureIgnoreCase))
            {
                return "Hello boss";
            }
            return "Hello guest";
        }
    }
}

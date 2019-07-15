using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars
{
    public class SixKyu
    {
        public static int find_it(int[] seq)
        {

            Array.Sort(seq);

            for (int i = 0; i < seq.Length + 2; i++)
            {
                if (seq[i] == seq[i + 1] && seq[i] == seq[i + 2])
                {
                    return seq[i];
                }


            }


            return -1;
        }




        public static void Wave(string str)
        {
            str.ToLower();
            

            List<string> Mexican = new List<string> { };

            for (int i = 0; i < str.Length; i++)
            {
                //strChar.Add(str[i]);
                if (str[i].ToString().StartsWith(str[i].ToString().ToLower()))
                { 
                    Mexican.Add(str[i].ToString().ToUpper());
                }
            }



            Console.WriteLine( Mexican[0]);
        }
        //Bouncing Balls
        public static int bouncingBall(double h, double bounce, double window)
        {
            int bounceTimes = 1;
            double c = h;
            while (h * bounce > window)
            {
                bounceTimes += 2;
                h -= (h - (h * bounce));
            }
            return (c * bounce) > window ? bounceTimes : -1;

        }

        //Stop gninnipS My sdroW!
        public static string SpinWords(string sentence)
        {

            foreach (var word in sentence.Split(' '))
            {
                int num = word.Length;
                
                if (num > 5 )
                {
                    char[] arr = word.ToCharArray();
                    Array.Reverse(arr);
                    return new string(arr);
                 }
                else
                    return word;
            }
            return null;
            
        }

        public static string Balance(string book)
        {
                //string formatted = Regex.Replace(book, "[^a-zA-Z0-9_._ ]+", "", RegexOptions.Compiled);
            string[] words = new string[book.Length];
            StringBuilder list = new StringBuilder();
            foreach (char letter in book)
            {
                if(letter == '\n')
                {
                    list.Append(letter + '\n');
                }
            }

            return list.ToString();
        }
        
    }
    
}

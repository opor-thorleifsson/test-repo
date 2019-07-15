using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeWars
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InterestCalculator();

            //string a = "abcd\nefgh\nijkl\nmnop";

            //Console.Write(sevenKyu1.Disemvowel("What are you, a communist?"));
            // Dictionary<string, string> test = new Dictionary<string, string>() { { "Tim", "accounts" }, { "Jim", "trading" }, { "Sandy", "regulation" }, { "Andy", "accounts" }, { "Katie", "finance" }, { "Laura", "IS" } };
            //foreach (var val in sevenKyu1.OrderedCount("Hello World"))
            //{
            //    Console.WriteLine(val);
            //}

            string names = "H1233.00\n125 Hardware;! 24.80?\n123 Flowers 93.50;\n127 Meat 120.90\n120 Picture 34.00\n124 Gasoline 11.00\n" +
                    "123 Photos;! 71.40?\n122 Picture 93.50\n132 Tyres;! 19.00,?;\n129 Stamps; 13.60\n129 Fruits{} 17.60\n129 Market;! 128.00?\n121 Gasoline;! 13.60?";
            int test = 345678;
            Console.WriteLine(sevenKyu1.DescendingOrder(test));
            Console.ReadKey();
        }

     

        static void InterestCalculator()
        {
            Double interest, initialInvestment, months;
            Double earnings = 0.0;
            Console.Write("How much is the annaul interest? ");
            interest = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("How much is your intial investment? ");
            initialInvestment = Convert.ToDouble(Console.ReadLine());

            Console.Write("How many months do you plan to leave the monies in? ");
            months = Convert.ToDouble(Console.ReadLine());

            earnings = initialInvestment * (1 + interest * (months / 12));



            Console.Write(earnings);
        }
    }
}

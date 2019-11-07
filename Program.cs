using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSTR1___Substring_Check__Bug_Funny_
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "";
            string[] data = new string[input.Length];



            string a = "";
            string b = "";


            int n = 24;
            int[] results = new int[n];

            for(int i = 0; i < n; i++)
            { 
                input = Console.ReadLine();
                data = input.Split(' ');
                a = data[0];
                b = data[1];

                if (a.Length <= 10 && b.Length <=5)
                {
                    results[i] = CheckString(a, b);
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(results[i]);
            }




                Console.ReadKey();
        }

        public static int CheckString(string a ,string b)
        {

            int result=  a.IndexOf(b, 0, a.Length);

            if(result >= 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }

    }
}

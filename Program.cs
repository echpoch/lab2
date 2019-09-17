using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;

            string str = "IliaNaibich";

            bool flag = true;

            float fnumber = number;

            float fnumber2 = (float)number;

            double dnumber = number;

            double dnumber2 = (double)number;

            Object inumber = number;        //упаковка

            Object sstr = str;              // упаковка

            int unbox = (int)inumber;       // распаковка

            string unbox2 = (string)sstr;   //распаковка

            string output = String.Format("My name is {0}", str);

            Console.WriteLine($"My name is {str}"); // интерполяция 

            Console.WriteLine(output);



            //ступенчатый массив
            int[][] myArr = new int[4][];
            myArr[0] = new int[4];
            myArr[1] = new int[6];
            myArr[2] = new int[3];
            myArr[3] = new int[4];




            //int? a = 1;
            //int? b = null;
            //console.writeline(b ?? a);

            string str1 = "IL";

            string str2 = "IA";
          

            int x = String.Compare(str1, str2);

            Console.WriteLine(x);

            bool contains = str.Contains(str2);

            Console.WriteLine(contains);

            string str3 = str.Substring(4);

            Console.WriteLine(str3);

      

            String stin = "1 2 3 4 5 6 7 8 9";

            str = stin.Replace(" ", ",");

            Console.WriteLine(str);

            string n = null
                ;
            bool c = String.IsNullOrEmpty(n);

            Console.WriteLine(c);

            dynamic h = 5;

            h = "str";

            Console.WriteLine(h);

            int? p = null;

            Console.WriteLine(p);

            (int, double) kort = (1, 2.3);
            sum(kort.Item1, kort.Item2);


            var tuple = (count: 5, sum: 10); ///именованный кортеж
            Console.WriteLine(tuple.count); // 5
            Console.WriteLine(tuple.sum); // 10


           checked_test();

            Console.ReadKey();


        }
        static void sum(int a, double k)
        {
            double res = a + k;
            Console.WriteLine($" suma korteza {res}");
        }
        static void checked_test()
        {
            int v = 2147483647;
            int r = 132123;
            int c = unchecked(v + r);
            Console.WriteLine(c);
        }
    }
}

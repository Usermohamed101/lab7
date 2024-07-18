using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class calculator
    {

        public delegate int calcdlg(int x, int y);






       public static void calc(int x, int y, calcdlg fun)
        {

            Console.Write(fun(x, y));
            Console.WriteLine();



        }



        public static int sub(int x, int y) {
            Console.Write($"{x}-{y} =");
            return x - y;
        }

        public  static int add(int x, int y)
        {
            Console.Write($"{x}+{y} =");
            return x + y;
        }

        public static int multiply(int x, int y)
        {
            Console.Write($"{x}*{y} =");
            return x * y;
        }

         public static int divide(int x, int y)
        {
            Console.Write($"{ x}/{ y} =");
            return x / y;
        }



    }
}

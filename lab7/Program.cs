using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region task1


            //while (true)
            //{
            //    Console.WriteLine("please enter you name ");
            //    string name = Console.ReadLine();

            //    Console.WriteLine($"hello {name}, if you wanna see history write H if you wanna calculte your bmi write B");
            //    char c = char.Parse(Console.ReadLine());

            //    if (c == 'B')
            //    {
            //        Console.WriteLine("enter the required unit m/f");
            //        char m = char.Parse(Console.ReadLine());

            //        bool isMetric = (m == 'm');
            //        Console.WriteLine("enter your weight");

            //        double weight =double.Parse(Console.ReadLine());
            //        Console.WriteLine("enter your height");

            //        double height =double.Parse(Console.ReadLine());
            //        BMI p1=new BMI(name, weight, height, isMetric);


            //        p1.showData();
            //        Console.ReadKey();
            //        Console.Clear();


            //    }
            //    else
            //    {
            //        BMI.displayHistory();
            //        Console.ReadKey();
            //        Console.Clear();
            //    }
            //}

            #endregion





            #region task2

            int x = 10;
            int y = 11;
            calculator.calc(x, y, calculator.add);
            calculator.calc(x, y, calculator.sub);
            calculator.calc(x, y, calculator.multiply);


            #endregion
            Console.ReadKey();
        }
    }
}

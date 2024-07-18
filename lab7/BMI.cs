using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class BMI
    {
        public static Stack<string> stack = new Stack<string>();
        public string name { get; set; }
        public double height { get; set; }
       
        public double weight { get; set; }
        public double Bmi { get; set; }
        public string BmiCategory { get; set; }

        public void calculateBmi(bool factor)
        {

            Bmi = (height) / (Math.Pow(weight, 2.0));
            if (!factor)
                Bmi *= 703;
            stack.Push($"name :{this.name}, BMI :{this.Bmi}, category:{this.BmiCategory}");
            
            
        }
        void detectCategory()
        {
            if (Bmi < 18.5)
                BmiCategory = "Underweight";
            else if (Bmi <= 24.9)
                BmiCategory = "Normal Weight";
            else if (Bmi <= 29.9)
                BmiCategory = "overweight";
            else if (Bmi <= 34.9)
                BmiCategory = "obesity class I";
            else if (Bmi <= 39.9)
                BmiCategory = "obesity class II";
            else
                BmiCategory = "obesity class III";

        }
        public BMI()
        {
            
        }
        public BMI(string name,double weight,double height,bool factor)

        {
            this.weight = weight;
            this.height = height;
            this.name = name;
            detectCategory();
            calculateBmi(factor);
        }
        public void showData()
        {
            Console.WriteLine($"name :{this.name}, BMI :{this.Bmi}, category:{this.BmiCategory}");
        }
        public static void displayHistory()
        {
            Console.WriteLine("=========history==========");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;

namespace ClassCalculator
{
    class Calculator
    {
        public double num1;
        public double num2;
        public Calculator(){}
        public Calculator(double num1,double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Minus(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Product(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Division(double num1, double num2)
        {
            if (num2 != 0) return num1/num2;
            else return 0;
        }
        public void GetValue()
        {
            Console.WriteLine($"{num1} + {num2} = {Sum(num1, num2)}");
            Console.WriteLine($"{num1} - {num2} = {Minus(num1, num2)}");
            Console.WriteLine($"{num1} * {num2} = {Product(num1, num2)}");
            Console.WriteLine($"{num1} / {num2} = {Division(num1, num2)}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Добро пожаловать в класс Calculator!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("num1 = "); double.TryParse(Console.ReadLine(), out double num1);
            Console.Write("num2 = "); double.TryParse(Console.ReadLine(), out double num2);
            var res = new Calculator(num1, num2);
            res.GetValue();
        }
    }
}

using System;

namespace DesignPatterns
{
    public class Calculator 
    {
        double memory = 0;
        public Calculator Digit(double d) 
        {
            
        }
        public Calculator Operator(char op) 
        {
        
        }
        public double Result() 
        {
            return memory;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            calc.Digit(5).Operator('+').Digit(3).Result();
        }
    }
}

using System;

namespace ConsoleCalculator
{
    class Calc{
        public static void Main(string[] args){
            System.Console.WriteLine("------------Simple Calculator------------");
            System.Console.WriteLine("Enter your operator (+, - , *, /): ");
            char op = Convert.ToChar(System.Console.ReadLine());
            System.Console.WriteLine("Enter number 1: ");
            int num1 = Convert.ToInt32(System.Console.ReadLine()); 
            System.Console.WriteLine("Enter number 2: ");
            int num2 = Convert.ToInt32(System.Console.ReadLine());
            
            switch (op)
            {
                case '+':
                    int sum = num1 + num2;
                    System.Console.WriteLine($"Sum : {sum}");
                    break;
                case '-':
                    int diff = num1 - num2;
                    System.Console.WriteLine($"Diff: {diff}");
                    break;
                case '*':
                    int multi = num1 * num2;
                    System.Console.WriteLine($"Multiplication: {multi}");
                    break;
                case '/':
                    int div = num1 / num2;
                    System.Console.WriteLine($"Division : {div}");
                    break;
                default:
                    System.Console.WriteLine("NO operator matched");
                    break;
            }
        }
    }
}
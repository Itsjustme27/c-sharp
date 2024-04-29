using System;

namespace App
{
    class App{
        public static void Main(string[] args){
            int a, b, c;
            Console.Write("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if(a > b && a > c){
                Console.WriteLine($"{a} is greatest");
            }else if (b > c && b > a)
            {
                Console.WriteLine($"{b} is greatest");
            }else{
                Console.WriteLine($"{c} is greatest");
            }
        }
    }
}
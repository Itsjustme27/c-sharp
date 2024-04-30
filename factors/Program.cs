using System;

namespace App
{
    class App{
        public static void Main(string[] args){
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++){
                if(num%i == 0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
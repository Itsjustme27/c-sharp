﻿public class Program {
    public static void Main(string[] args){
        int days;
        Console.WriteLine("------Day Seleector------");
        Console.WriteLine("Enter a number: (1-7)");
        days = Convert.ToInt32(Console.ReadLine());
        switch(days) {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Enter valid number");
                break;
        }
    }
}
using System;

namespace App
{
    class App
    {
        public static void Main(string[] args)
        {
            string name;
            float math, digital, it, averageMarks;
            System.Console.WriteLine("Enter student Name: ");
            name = Console.ReadLine();
            System.Console.WriteLine("Enter marks of Math: ");
            math = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter marks of IT: ");
            it = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter marks of Digital Systems: ");
            digital = Convert.ToInt32(Console.ReadLine());
            averageMarks = (math + it + digital) / 3;
            Console.WriteLine($"Name: {name}\n Math: {math}\n IT: {it}\n Digital Logic: {digital}\n Average: {averageMarks}");
            if (averageMarks > 90)
            {
                Console.WriteLine("Grade A+");
            }
            else if(averageMarks > 80 && averageMarks < 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (averageMarks > 70 && averageMarks < 80)    
            {
                Console.WriteLine("Grade B+");
            }
            else if (averageMarks > 60 && averageMarks < 70)
            {
                Console.WriteLine("Grade B");
            }
            else if (averageMarks <= 60)
            {
                Console.WriteLine("Grade C");
            }
        }
    }
}
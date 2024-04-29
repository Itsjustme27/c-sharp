using System;
namespace Helloworld
{
    

    private class App
    {
        public static void Main(string[] args){
            Console.WriteLine("Write first name: ");
            string fname = Console.ReadLine();  
            Console.WriteLine("Write your Last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Write your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your address: ");
            string address =Console.ReadLine();
            Console.WriteLine($"First Name: {fname}\n Last Name: {lname}\nAge: {age}\n Address: {address}");
        }

    }
}
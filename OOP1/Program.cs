using System;

namespace Program {
    public class Program {
        public static void Main(string[] args) {
            Student student1 = new Student();
            Console.WriteLine("Student details");
            Console.Write("Enter student name: ");
            student1.name = Convert.ToString(Console.Read());
            Console.Write("Enter student age: ");
            student1.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student address: ");
            student1.address = Convert.ToString(Console.Read());
            Console.Write("Enter student Faculty: ");
            student1.faculty = Convert.ToString(Console.Read());

            Console.WriteLine(
                $"\n\nStudent Information:\n Student name: {student1.name}\n Student Age: {student1.age}\n Student Address: {student1.address}\n Faculty: {student1.faculty}"
                );
        }
    }
}
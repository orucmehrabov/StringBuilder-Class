using System;

namespace StringBuilder__Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Oruc", "Mehrabov", 25, "Male", true, 87);
            Console.WriteLine(student.GetInfo());
        }

    }
    class Student
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string Gender;
        public bool isGraduated;
        public byte Point;
        public Student(string name, string surname, byte age, string gender, bool graduated, byte point)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            Point = point;
            isGraduated = graduated;
            if (graduated = true)
            {
                Console.WriteLine("You're graduated");
            }
            if (point >= 80)
            {
                Console.WriteLine("You have chance for a second exam");
            }
            else
            {
                Console.WriteLine("You failed the exam");
            }
        }
        public string GetInfo()
        {
            return $"Name:{Name} Surname: {Surname}";
        }
    }
}

using System.Drawing;
using System.Xml.Linq;

namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student nicat = new Student("Nicat","Aliyev","AB106",75);
            //nicat.Name = "Nicat";
            //nicat.Surname = "Aliyev";
            //nicat.Group = "AB106";
            //nicat.Point = 75;
            nicat.GetInfo();
            nicat.CheckGraduation();
            nicat.GetDiplomDegree();
        }
    }
    public class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool IsGraduated;


        public Student(string name, string surname, string group, byte point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = true;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Group}-{Name} {Surname} {Point}");
        }
        public void CheckGraduation()
        {
            if (Point<65)
            {
                Console.WriteLine("Mezun olmayib");
            }
            else
            {
                Console.WriteLine("Mezun olub");
            }
        }
        public void GetDiplomDegree()
        {
            if (Point<65)
            {
                Console.WriteLine("No Diploma");
            }
            else if (65>=Point && Point<80)
            {
                Console.WriteLine("Simple Diploma");
            }
            else if (80>=Point && Point < 90)
            {
                Console.WriteLine("Honor Diploma");
            }
            else if (Point>90)
            {
                Console.WriteLine("High Honor Diploma");
            }
        }

    }

}
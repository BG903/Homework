using System;

namespace Homework
{
    enum Genders
    {
        Male,
        Female
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    struct Point
    {
        public double x;
        public double y;
        public double z;
        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
        }
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y, p1.z - p2.z);
        }
        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.x * p2.x, p1.y * p2.y, p1.z * p2.z);
        }
        public static Point operator /(Point p1, Point p2)
        {
            if (p2.x == 0 || p2.y == 0 || p2.z == 0)
                throw new Exception();
            return new Point(p1.x / p2.x, p1.y / p2.y, p1.z / p2.z);
        }

    }
    struct Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Post { get; set; }
        public int Salary { get; set; }
        public Employee(string name,string surname,string post,int salary)
        {
            Name = name;
            Surname = surname;
            Post = post;
            Salary = salary;
        }
      
        public static implicit operator Person(Employee e)
        {
            return new Employee();
        }
    }
    struct Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Genders Gender { get; set; }
        public Person(string name, string surname,int age, Genders gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        public static explicit operator Employee(Person p)
        {
            return new Employee();
        }

        public static double Average(Person[] people)
        {
            double sum = people[0].Age;    
            for(int i = 1; i < people.Length; i++)
            {
                sum+=people[i].Age;
            }

            return sum/people.Length;
        }
    }
}

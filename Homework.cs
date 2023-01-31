using System;

namespace Homework
{
    enum Genders
    {
        Male,
        Female
    }
    public delegate int FactorialDelegate (int x);
    public delegate void PrintDelegate();
    class Homework
    {
        static void Main(string[] args)
        {
            var f = new FactorialDelegate(Factorial);
            int result = f(5);
            Console.WriteLine(result);
            var first = new PrintDelegate(Method1);
            var second = new PrintDelegate(Method2);
            var third = new PrintDelegate(Method3);
            var fourth = new PrintDelegate(Method4);

            first += second + third + fourth;
            first();
            
        }
        static void Method1()
        {
            Console.WriteLine("Method 1");
        }
        static void Method2()
        {
            Console.WriteLine("Method 2");
        }
        static void Method3()
        {
            Console.WriteLine("Method 3");
        }
        static void Method4()
        {
            Console.WriteLine("Method 4");
        }
        static int Factorial(int x)
        {
            if(x == 1)
                return x;
            return x * Factorial(x - 1);
        }
    }
#region Old
    //class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public string Address { get; set; }
    //    public Person()
    //    {
    //        Address = "Address not defined";
    //    }
    //    public Person(string name, int age) : this()
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //    public Person(string name, int age, string address) : this(name, age)
    //    {
    //        Address = address;
    //    }
    //}
    //static class Mathhelper
    //{
    //    private static double PI;
    //    static Mathhelper()
    //    {
    //        PI = 3.1415926536;
    //    }
    //    public static double Sin(double x)
    //    {

    //        return Math.Sin(x*PI/180);
    //    }
    //    static double Cos(double x)
    //    {
    //        return Math.Cos(x*PI/180);
    //    }
    //    static double Tan(double x)
    //    {
    //        return Sin(x) / Cos(x);
    //    }
    //}
    //struct Rectangle
    //{
    //    public double Width { get; }
    //    public double Height { get; }
    //    public Rectangle(double width, double height)
    //    {
    //        Width = width;
    //        Height = height;
    //    }
    //    public double Area()
    //    {
    //        return Width * Height;
    //    }
    //    public static double Area(double width, double height)
    //    {
    //        return width * height;
    //    }
    //    public double Perimeter()
    //    {
    //        return 2 * Width + 2 * Height;
    //    }
    //    public static double Perimetr(double width, double height)
    //    {
    //        return 2 * width + 2 * height;
    //    }
    //}
    //class BankAccount
    //{
    //    public int AccountNumber { get; private set; }
    //    public double Balance { get; private set; }
    //    public string HolderName { get; private set; }

    //    public BankAccount(int accountNumber, double balance, string holderName)
    //    {
    //        AccountNumber = accountNumber;
    //        Balance = balance;
    //        HolderName = holderName;
    //    }

    //    public void Deposit(double amount)
    //    {
    //        Balance += amount;
    //    }
    //    public void Draw(double amount)
    //    {
    //        if (Balance >= amount)
    //            Balance -= amount;
    //        else
    //            return;
    //    }
    //    public void PrintAccountInfo()
    //    {
    //        Console.WriteLine($"{nameof(HolderName)} - {HolderName}.\n{nameof(AccountNumber)} - {AccountNumber}.\n{nameof(Balance)} - {Balance}.");
    //    }
    //}
    
    //struct Point
    //{
    //    public double x;
    //    public double y;
    //    public double z;
    //    public Point(double x, double y, double z)
    //    {
    //        this.x = x;
    //        this.y = y;
    //        this.z = z;
    //    }
    //    public static Point operator +(Point p1, Point p2)
    //    {
    //        return new Point(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
    //    }
    //    public static Point operator -(Point p1, Point p2)
    //    {
    //        return new Point(p1.x - p2.x, p1.y - p2.y, p1.z - p2.z);
    //    }
    //    public static Point operator *(Point p1, Point p2)
    //    {
    //        return new Point(p1.x * p2.x, p1.y * p2.y, p1.z * p2.z);
    //    }
    //    public static Point operator /(Point p1, Point p2)
    //    {
    //        if (p2.x == 0 || p2.y == 0 || p2.z == 0)
    //            throw new Exception();
    //        return new Point(p1.x / p2.x, p1.y / p2.y, p1.z / p2.z);
    //    }

    //}
    //struct Employee
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public string Post { get; set; }
    //    public int Salary { get; set; }
    //    public Employee(string name, string surname, string post, int salary)
    //    {
    //        Name = name;
    //        Surname = surname;
    //        Post = post;
    //        Salary = salary;
    //    }

    //    public static implicit operator Person(Employee e)
    //    {
    //        return new Employee();
    //    }
    //}
    //struct Person
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public int Age { get; set; }
    //    public Genders Gender { get; set; }

    //    public Person(string name, string surname, int age, Genders gender)
    //    {
    //        Name = name;
    //        Surname = surname;
    //        Age = age;
    //        Gender = gender;
    //    }

    //    public static explicit operator Employee(Person p)
    //    {
    //        return new Employee();
    //    }

    //    public static double Average(Person[] people)
    //    {
    //        double sum = people[0].Age;
    //        for (int i = 1; i < people.Length; i++)
    //        {
    //            sum += people[i].Age;
    //        }

    //        return sum / people.Length;
    //    }
    //}
    #endregion
}

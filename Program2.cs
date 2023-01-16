using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Coordinates coordinates = new Coordinates(new int[] { 1, 2 }, new int[] { 5, 6 });

            Console.WriteLine("Distance is - "+coordinates.GetDistance(coordinates.FirstPoint,coordinates.SecondPoint));


            Things things = new Things("Book",10);
            Things things2 = new Things("Pen", 5);

            Console.WriteLine(Things.ThingsCount);
        }
        struct Coordinates
        {
            public int[] FirstPoint { get; set; }
            public int[] SecondPoint { get; set; }
            public Coordinates(int[] firstPoint,int[] secondPoint)
            {
                FirstPoint = firstPoint;
                SecondPoint = secondPoint;
            }
            public double GetDistance(int[] firstPoint,int[] secondPoint)
            {
                return Math.Sqrt(Math.Pow(firstPoint[0] - secondPoint[0], 2) + Math.Pow(firstPoint[1] - secondPoint[1], 2));
            }
        }

        struct Things
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public static int ThingsCount = 0;
            public Things(string name,int price)
            {
                Name = name;
                Price = price;
                ThingsCount++;
            }
        }
    }
}

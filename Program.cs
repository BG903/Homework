using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matrix = new int[5, 5];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(10,100);
                    Console.Write($"{matrix[i,j]}, ");
                }
                Console.WriteLine();
            }
            int sum=0, count=0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for( int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j >= i)
                    {
                        sum+=matrix[i, j];
                        count++;
                    }
                }
            }
            Console.Write("1)");
            Console.WriteLine("Answer = {0}",sum/count);
            int count2 = 0;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i + j <= matrix.GetLength(0) - 1)
                    {
                        if(matrix[i, j] % 2 != 0)
                        {
                            count2++;
                        }
                    }
                    Console.Write(matrix[i,j]+", ");
                }
                Console.WriteLine();
            }
            Console.Write("2)");
            Console.WriteLine("Answer = {0}", count2);
        }
    }
}

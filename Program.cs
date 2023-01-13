using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            #region First homework


            //111
            //double y, n = random.Next(5), x = 3;
            //y = Math.Pow(x, 4 * n + 1) / (4 * n + 1);
            //Console.WriteLine($"N = {n}, X = {x} \nY = {y}");

            //118
            //double y, n = random.Next(5), x = 3;
            //y = Math.Pow(Math.Abs(2 * x + n),n)/((n+1)*(n+2));
            //Console.WriteLine($"N = {n}, X = {x} \nY = {y}");

            //74
            //double y;
            //for(double x = -3.8; x <= 5.4; x += 0.3)
            //{
            //    y = Math.Pow(2, x + 4);
            //    Console.WriteLine($"X = {x}, Y = {y}");
            //}

            //77
            //double y,x = random.Next(-8,10);
            //if (x > 3)
            //{
            //    y = x * x + 4 * Math.Pow(x, 8);
            //}
            //else
            //{
            //    y = 0;
            //}
            //Console.WriteLine($"X = {x}, Y = {y}");

            //12
            //double y, x = random.Next(-10, 10);
            //if (x <= 5 && x >= -5)
            //{
            //    y = Math.Pow(1 + x * x, 6);
            //}
            //else if (x > 5)
            //{
            //    y = Math.Cos(Math.Pow(Math.Log(Math.Abs(x), Math.E), 2) + Math.Pow(x, 8));
            //}
            //else
            //{
            //    y = x;
            //}
            //Console.WriteLine($"X = {x}, Y = {y}");

            //4
            //double y, x = random.Next(100);
            //y = Math.Log(Math.Pow(Math.E, x) + 1, Math.E + Math.Pow(x * x + 4, 1 / 3));
            //Console.WriteLine($"X = {x}, Y = {y}");

            #endregion


            //1)Factorial

            //int n = 5,answer = n;
            //for(int i = n-1; i !=1; i--)
            //{
            //    answer *= i;
            //}
            //Console.WriteLine(answer);
            //Console.WriteLine(Factorial(5));

            //3)1)

            //int[] array = new int[10];
            //int answer = 1;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(21);
            //    Console.Write(array[i] + ", ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 5 == 2)
            //        answer *= array[i];
            //}
            //Console.WriteLine(answer);

            //3)2)

            //int[] array = new int[10];
            //int answer=0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(21);
            //    Console.Write(array[i] + ", ");
            //}
            //Console.WriteLine();
            //for(int i = 0; i < array.Length; i++)
            //{
            //    if((array[i] + i) % 3 == 0)
            //    {
            //        answer += array[i] * array[i];
            //        Console.Write(array[i]+", ");
            //    }
            //}
            //Console.WriteLine(answer);

            //3)3)

            //int[] array = new int[10];
            //int k = 10;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(21);
            //    Console.Write(array[i] + ", ");
            //}
            //Console.WriteLine();
            //for(int i = 0; i < array.Length; i++)
            //{
            //    if(array[i] < k)
            //    {
            //        for(int j = i; j < array.Length-1; j++)
            //        {
            //            array[j] = array[j+1];
            //        }
            //        Array.Resize(ref array, array.Length - 1);
            //        i--;
            //    }
            //}
            //for(int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i]+", ");
            //}


            //Bonus

            //int[] array = new int[10];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(21);
            //    Console.Write(array[i] + ", ");
            //}
            //Console.WriteLine();
            //for(int i = 1; i < array.Length; i++) 
            //{ 
            //    if(array[i] < array[i - 1])
            //    {
            //        for (int j = i; j < array.Length; j++)
            //        {
            //            int temp = array[j];
            //            array[j] = array[j-1];
            //            array[j-1] = temp;
            //        }
            //        i = 0;
            //    }
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + ", ");
            //}


            //1 1 2 3 5 8 13 21

            //int n1 = 0, n2 = 1, n3, i, number;
            //Console.Write("Enter the number of elements: ");
            //number = int.Parse(Console.ReadLine());
            //Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            //for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            //{
            //    n3 = n1 + n2;
            //    Console.Write(n3 + " ");
            //    n1 = n2;
            //    n2 = n3;
            //}

            //Fibonacci

            //int n = 12;
            //int[] array = new int[n];
            //array[0] = 0;
            //Console.Write(array[0]+", ");
            //array[1] = 1;
            //Console.Write(array[1]+", ");
            //for(int i = 2;i < array.Length;i++)
            //{
            //    array[i] = array[i-1]+array[i-2];
            //    Console.Write(array[i]+", ");
            //}
            //Console.WriteLine();
            //int sum = 0;
            //for(int i = 1;i < array.Length; i++)
            //{
            //    sum += array[i];
            //}
            //Console.WriteLine($"Sum is {sum}, N = {n}");

            //Console.WriteLine($"Sum is {Fi(n-2,0,1,0)}, N = {n}");
        }
        static int Factorial(int n)
        {
            int answer = n;
            if (n == 1)
                return answer;
            return answer * Factorial(n - 1);
        }
        static int Fi(int n,int x,int y,int sum)
        {
            if (sum == 0)
                sum++;
            int temp;
            temp = x + y;
            sum += temp;
            x = y;
            y = temp;
            Console.Write(temp +" ");
            if (n == 1)
            {
                return sum;
            }
            return Fi(n-1, x, y,sum);
        }
    }
}

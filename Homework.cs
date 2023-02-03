using System;

namespace Homework
{
    public delegate void NewsDelegate();
    class Homework
    {
        static void Main(string[] args)
        {
            News news = new News();
            news.NewsDelegate += NewsToday;
            news.PrintNews();

            int[] numbers = { 1, 2, 3 };
            try
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    throw new NewExcepton("");
                }
                Console.WriteLine(numbers[index]);

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NewException ex)
            {
                //
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(String.Join(",", numbers));
            }
        }
        static void NewsToday()
        {
            Console.WriteLine("News today");
        }
    }
    class NewExcepton:Exception
    {
        public NewExcepton(string msg):base (msg)
        {

        }
    }
    class News
    {
        public static int NewsCount = 0;
        private NewsDelegate newsDelegate;
        public event NewsDelegate NewsDelegate
        {
            add { newsDelegate += value; NewsCount++; }
            remove { newsDelegate -= value; NewsCount--; }
        }
        public void PrintNews()
        {
            newsDelegate();
        }
    }

}

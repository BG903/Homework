using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    enum Tick
    {
        Empty,
        X,
        O
    }

    class Program
    {
        const char EMPTY = '-';

        public static void Main()
        {
            byte firstPLayerCount = 0, seconfPlayerCount = 0;

            while (true)
            {
                Console.WriteLine($"X - {firstPLayerCount}  :  O - {seconfPlayerCount}");
                byte playCount = 0;
                Tick[,] grid = new Tick[3, 3];
                FillGrid(grid, Tick.Empty);
                PrintGrid(grid);

                bool isFirstPlayer = true;

                Tick firstPlayer = Tick.X;
                Tick secondPlayer = Tick.O;
                bool isFinished = false;
                while (true)
                {
                    isFinished = SetTick(grid, isFirstPlayer ? firstPlayer : secondPlayer);
                    PrintGrid(grid);
                    playCount++;
                    if (isFinished || playCount == 9)
                        break;
                    isFirstPlayer = !isFirstPlayer;
                }


                if (isFinished)
                {
                    if (isFirstPlayer)
                        firstPLayerCount++;
                    else
                        seconfPlayerCount++;
                }

                Console.Clear();

                if (playCount == 9 && !isFinished)
                    Console.WriteLine("Draw");
                else
                    Console.WriteLine("Winner is {0}", isFirstPlayer ? firstPlayer : secondPlayer);

            }

        }

        static void PrintGrid(Tick[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == Tick.Empty)
                    {
                        Console.Write("{0}\t", EMPTY);
                    }
                    else
                    {
                        Console.Write("{0}\t", grid[i, j]);
                    }
                }

                Console.WriteLine();
            }
        }

        static void FillGrid(Tick[,] grid, Tick tick)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = tick;
                }
            }
        }

        static Tick GetTick()
        {
            string input;
            do
            {
                Console.Write("Please input your tick: ");
                input = Console.ReadLine();
            } while (input.Length > 1 || input.ToUpper() != Tick.X.ToString() || input.ToUpper() != Tick.O.ToString());

            return input.ToUpper() == Tick.X.ToString() ? Tick.X : Tick.O;
        }

        static bool SetTick(Tick[,] grid, Tick tick)
        {
            string[] inputCoords;
            int i;
            int j;
            do
            {
                Console.Write("Input Coord (i,j): ");
                string input = Console.ReadLine();
                inputCoords = input.Split(',');
            } while (!int.TryParse(inputCoords[0], out i) || !int.TryParse(inputCoords[1], out j) ||
                     grid[i, j] != Tick.Empty);

            grid[i, j] = tick;

            if (CheckHorizontal(grid, tick, i, j) || CheckVertical(grid, tick, i, j) || ChecktDiagonal(grid, tick, i, j))
            {
                return true;
            }
            return false;
        }


        static bool CheckHorizontal(Tick[,] grid, Tick tick, int i, int j)
        {
            for (int k = 0; k < grid.GetLength(1); k++)
            {
                if (k == j)
                {
                    continue;
                }

                if (grid[i, k] != tick)
                {
                    return false;
                }
            }

            return true;
        }

        static bool CheckVertical(Tick[,] grid, Tick tick, int i, int j)
        {
            for (int k = 0; k < grid.GetLength(0); k++)
            {
                if (k == i)
                {
                    continue;
                }

                if (grid[k, j] != tick)
                {
                    return false;
                }
            }

            return true;
        }

        static bool ChecktDiagonal(Tick[,] grid, Tick tick, int i, int j)
        {
            if (grid[0, 0] != Tick.Empty || grid[2, 2] != Tick.Empty)
                if (grid[0, 0] == grid[1, 1] && grid[2, 2] == grid[1, 1])
                    return true;
            if (grid[0, 2] != Tick.Empty || grid[2, 0] != Tick.Empty)
                if (grid[2, 0] == grid[1, 1] && grid[0, 2] == grid[1, 1])
                    return true;

            return false;
        }
    }
}

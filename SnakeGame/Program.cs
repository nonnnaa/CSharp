using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SnakeGame
{
    class Program
    {
        static void Draw(int x, int y, string content)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(content);
        }
        static void DrawBorder(int height, int width)
        {
            for (int i = 0; i <= height + 1; i++)
            {
                for (int j = 0; j <= width + 1; j++)
                {
                    if (i == 0 || i == height + 1)
                    {
                        Draw(j, i, "-");
                    }
                    if (j == 0 || j == width + 1)
                    {
                        Draw(j, i, "|");
                    }
                }
            }
        }


        static void DrawSnake(List<int> xSnake, List<int> ySnake)
        {
            for (int i = 0; i < xSnake.Count; i++)
            {
                Draw(xSnake[i], ySnake[i], "o");
            }
        }

        static void DrawFood(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('x');
        }

        static void MoveSnake(List<int> xSnake, List<int> ySnake, char direction)
        {
            for (int i = xSnake.Count - 1; i > 0; i--)
            {
                xSnake[i] = xSnake[i - 1];
                ySnake[i] = ySnake[i - 1];
            }
            switch (direction)
            {
                case 'U':
                    ySnake[0]--;
                    break;
                case 'R':
                    xSnake[0]++;
                    break;
                case 'D':
                    ySnake[0]++;
                    break;
                case 'L':
                    xSnake[0]--;
                    break;
                default:
                    break;
            }
        }
        static void reverseSnake(List<int> xSnake, List<int> ySnake)
        {
            for (int i = 0; i < xSnake.Count / 2; i++)
            {
                xSnake[i] = xSnake[xSnake.Count - 1 - i];
                ySnake[i] = ySnake[ySnake.Count - 1 - i];
            }
        }
        static void DrawPoints(int points, int height)
        {
            Console.SetCursorPosition(0, height + 2);
            Console.Write("Points : " + points);
        }
        static void Main(string[] args)
        {
            int height = 30;
            int width = 50;

            List<int> xSnake = new List<int> { 6, 5, 4, 3, 2, 1 };
            List<int> ySnake = new List<int> { 1, 1, 1, 1, 1, 1 };

            char direction = 'R';
            bool check = false, ok = false;

            Random Food = new Random();
            int xFood = Food.Next(1, width + 1);
            int yFood = Food.Next(1, height + 1);

            int points = 0;
            while (!check)
            {
                MoveSnake(xSnake, ySnake, direction);


                // check xem snake cắn vào đuôi hay không 
                for (int i = 1; i < xSnake.Count; i++)
                {
                    if (xSnake[0] == xSnake[i] && ySnake[0] == ySnake[i])
                    {
                        check = true;
                        break;
                    }
                }

                // check xem snake chạm vào rìa hay không 
                if (xSnake[0] == 0)
                {
                    xSnake[0] = width;
                }
                else if (xSnake[0] == width + 1)
                {
                    xSnake[0] = 1;
                }
                if (ySnake[0] == 0)
                {
                    ySnake[0] = height;
                }
                else if (ySnake[0] == height + 1)
                {
                    ySnake[0] = 1;
                }

                // check xem snake có ăn food không 
                if (xSnake[0] == xFood && ySnake[0] == yFood)
                {
                    points++;
                    xFood = Food.Next(1, width + 1);
                    yFood = Food.Next(1, height + 1);
                    xSnake.Add(xSnake[xSnake.Count - 1]);
                    ySnake.Add(ySnake[ySnake.Count - 1]);
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo DirectionKey = Console.ReadKey();
                    switch (DirectionKey.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (direction == 'D') reverseSnake(xSnake, ySnake);
                            direction = 'U';
                            break;
                        case ConsoleKey.DownArrow:
                            if (direction == 'U') reverseSnake(xSnake, ySnake);
                            direction = 'D';
                            break;
                        case ConsoleKey.LeftArrow:
                            if (direction == 'R') reverseSnake(xSnake, ySnake);
                            direction = 'L';
                            break;
                        case ConsoleKey.RightArrow:
                            if (direction == 'L') reverseSnake(xSnake, ySnake);
                            direction = 'R';
                            break;
                        case ConsoleKey.Escape:
                            check = true;
                            break;
                        default:
                            break;
                    }
                }
                Console.Clear();
                DrawPoints(points, height);
                DrawBorder(height, width);
                DrawSnake(xSnake, ySnake);
                DrawFood(xFood, yFood);
                System.Threading.Thread.Sleep(100);
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    struct Location
    {
        public int X;
        public int Y;

        public Location(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            string mysnake = "Snake";
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1252);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = mysnake;
            Console.WriteLine(mysnake);
            Console.ForegroundColor = ConsoleColor.White;


            Location head = new Location(40, 12);
            List<Location> snake = new List<Location>();
            snake.Add(head);

            Location next;
            Location star = new Location(60, 20);

            while (true)
            {
                next = snake[0];
                Console.Clear();



                foreach (Location location in snake)
                {
                    Console.SetCursorPosition(head.X, head.Y);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write((char)178);
                }

                Console.SetCursorPosition(star.X, star.Y);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("*");
                Console.ResetColor();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.UpArrow:
                        if (head.Y > 0)
                            head.Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (head.Y < 24)
                            head.Y++;
                        break;

                    case ConsoleKey.LeftArrow:
                        if (head.X > 0)
                            head.X--;
                        break;

                    case ConsoleKey.RightArrow:
                        if (head.X < 79)
                            head.X++;
                        break;

                }
                snake.Insert(0, next);
                if (next.X == star.X && next.Y == star.Y)
                {
                    Random random = new Random();
                    star.X = random.Next(0, 80);
                    star.Y = random.Next(0, 25);
                }
                else
                {
                    snake.RemoveAt(snake.Count - 1);
                }


              



            }
        }
    }
}

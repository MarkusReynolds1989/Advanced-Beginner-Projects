using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Snake
{
    class Program
    {
        public static bool GameOver = false;
        public static SnakeBody snake;
        public static Fruits fruit;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            DrawMap();
            snake = new SnakeBody();
            fruit = new Fruits();
            snake.Init();
            fruit.Init();
            
            while (!GameOver)
            {
                Update();
                Draw();
            }
            
        }

        private static void Draw()
        {
            snake.Draw();
            fruit.Draw();
        }
        
        private static void Update()
        {
           snake.Update();
           fruit.Update();
        }
        
        public static void DrawMap()
        {
            // Left wall.
            Console.Write("+");
            foreach (var item in Enumerable.Range(1, 11))
            {
                Console.SetCursorPosition(0, item);
                Console.Write("|");
            }

            Console.SetCursorPosition(0, 11);
            Console.Write("+");
            // Top wall.
            foreach (var item in Enumerable.Range(1, 31))
            {
                Console.SetCursorPosition(item, 0);
                Console.Write("-");
            }

            Console.Write("+");
            // Right wall.
            foreach (var item in Enumerable.Range(1, 11))
            {
                Console.SetCursorPosition(32, item);
                Console.Write("|");
            }

            Console.SetCursorPosition(32, 11);
            Console.Write("+");

            // Bottom wall.
            foreach (var item in Enumerable.Range(1, 31))
            {
                Console.SetCursorPosition(item, 11);
                Console.Write("-");
            }
        }
    }
}
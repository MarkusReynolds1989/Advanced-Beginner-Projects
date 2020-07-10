using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    public class SnakeBody
    {
        public List<Point> Snake;

        public void Init() =>
            Snake = new List<Point> {new Point(1, 1)};

        public void Update(Point point)
        {
           Snake.First().SetPoint(point); 
        }

        public void Draw()
        {
            foreach (var item in Snake)
            {
                Console.SetCursorPosition(item.GetPoint().x, item.GetPoint().y);
                if (item == Snake.First())
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write("O");
                }
            }
        }
    }
}
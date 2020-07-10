using System;
using System.Collections.Generic;

namespace Snake
{
    public class Fruits
    {
        public List<Point> Fruit;
        private Random rand = new Random();

        public void Init() =>
            Fruit = new List<Point>{new Point(rand.Next(1, 21), rand.Next(1, 11))};
        
        public void Update()
        {
            
        }

        public void Draw()
        {
            Console.SetCursorPosition(Fruit[0].GetPoint().x, Fruit[0].GetPoint().y);
            Console.Write("@");
        }
    }
}
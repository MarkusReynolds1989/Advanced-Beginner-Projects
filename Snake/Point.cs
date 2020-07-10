namespace Snake
{
    public class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        
        // Return the point as an x and y tuple.
        public (int x, int y) GetPoint() =>
            (_x,_y);

        public void SetPoint(Point point)
        {
            _x = point._x;
            _y = point._y;
        }
    }
}
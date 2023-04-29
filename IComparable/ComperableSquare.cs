namespace Shape
{
    public class ComperableSquare : Rectangle, IComparable<ComperableCircle>
    {
        public ComperableSquare() { }
        public ComperableSquare(double size) 
        {
            this.setLength(size);
            this.setWidth(size);
        }
        public ComperableSquare(double size, string color, bool filled) 
        {
            this.setColor(color);
            this.setFilled(filled);
            this.setLength(size);
            this.setWidth(size);
        }
        public int CompareTo(ComperableCircle x)
        {
            double x1 = getArea();
            double x2 = x.getArea();
            if (x1 > x2) return 1;
            if (x1 < x2) return -1;
            return 0;
        }
    }
}
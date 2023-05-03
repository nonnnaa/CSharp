namespace Shape
{
  public class Rectangle : Shape, Resizeable
  {
    public double width = 0.0;
    public double length = 0.0;

    public Rectangle() {}

    public Rectangle(double width, double length)
    {
        this.width = width;
        this.length = length;
    }

    public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
    {
        this.width = width;
        this.length = length;
    }

    public double getWidth()
    {
        return width;
    }

    public virtual void setWidth(double width)
    {
        this.width = width;
    }

    public double getLength()
    {
        return length;
    }

    public virtual void setLength(double length)
    {
        this.length = length;
    }

    public double getArea()
    {
        return width * this.length;
    }

    public double getPerimeter()
    {
        return 2 * (width + this.length);
    }
    public void Resize(double f)
    {
        this.width += this.width * f;
        this.length += this.length * f;
    }
    public override string ToString()
    {
        return "A Rectangle with width = "
                + getWidth()
                + " and length = "
                + getLength()
                + ", which is a subclass of "
                + base.ToString();
    }
  }
}
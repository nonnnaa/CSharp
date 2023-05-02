namespace Shape
{
  public class Square : Shape, Resizeable
  {
    private double side = 0.0;
    public Square() {}

    public Square(double side) {
        this.side = side;
    }

    public Square(double side, string color, bool filled) : base (color, filled){
        this.side = side;
    }
    public double getSide()
    {
        return this.side;
    }
    
    public void setSide(double side)
    {
        this.side = side;
    }
    public void Resize(double f)
    {
        this.side += this.side * f;
    }
    public override string ToString()
    {
        return "A Square with side = "
                + getSide()
                + ", which is a subclass of "
                + base.ToString();
    }
  }
}

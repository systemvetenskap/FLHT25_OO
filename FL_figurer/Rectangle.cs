namespace FL_figurer;

public class Rectangle : Shape
{
    public double Width { get; private set; }
    public double Height { get; private set; }

    public override string Name => "Rektangel";

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }


    public override double GetArea()
    {
        return Width * Height;
    }
}

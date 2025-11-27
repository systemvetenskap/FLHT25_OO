using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_figurer;

public class Triangle : Shape
{
    public override string Name => "Triangel";
    public double BaseLength { get; set; }
    public double Height { get; set; }

    public Triangle(double height, double length)
    {
        BaseLength = length;
        Height = height;
    }

    // Detta är ett exempel på polymorfism
    public override double GetArea()
    {
        return BaseLength * Height * 0.5;
    }


}

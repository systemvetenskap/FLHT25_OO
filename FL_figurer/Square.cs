using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_figurer;

public class Square : Rectangle
{
    public override string Name => "Kvadrat";
    public Square(double side) : base(side, side)
    {
    }
}

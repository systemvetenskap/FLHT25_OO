using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_figurer;

public abstract class Shape
{
    public abstract string Name { get; }
    // en abstrakt metod som subklasserna (barnen) måste implementera
    public abstract double GetArea();
    
}

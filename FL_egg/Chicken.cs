using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FL_egg;

public class Chicken
{
    public string Name { get; set; } = "Agda";
    public int Id { get;  }

    public bool IsHungry => EnergyLevel <= 50;
    //public bool EnergyIsCritical => IsCritical();
    public int EnergyLevel { get; set; } 
    public Chicken(int id)
    {
        EnergyLevel = 100;
        Id = id;
    }

    public bool IsCritical()
    {
        return EnergyLevel <= 10;
        //if (EnergyLevel <= 10)
        //{
        //    return true;
        //}
        //return false;
    }

    public void Eat(int energy)
    {
        EnergyLevel += energy;
    }
}

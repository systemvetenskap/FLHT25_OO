using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_egg;

public class Chicken
{
    public string Name { get; set; } = "Agda";
    public int Id { get;  }
    public Chicken(int id)
    {
        Id = id;
    }
}

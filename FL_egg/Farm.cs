using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_egg;


// i den här klassen lägger vi all kod som styr logik
public class Farm
{
    private List<Egg> _eggs = new();




    public Farm()
    {
    }
    public List<Egg> GetAllEggs()
    {
        return _eggs;
    }

    public Chicken? HatchEgg(Egg egg)
    {
        Chicken? chicken = egg.Hatch();
        _eggs.Remove(egg);
        return chicken;
    }

    public void BuyEggs(int count)
    {
        for (int i = 1; i <= count; i++)
        {
            Egg egg = new Egg(i);
            _eggs.Add(egg);

        }
    }

    public List<Egg> GetFertileEggs()
    {
        List<Egg> fertiles = new List<Egg>();
        // uppdrag. Plocka fram alla fertila ägg
        foreach (Egg egg in _eggs)
        {
            // om ägget är IsFertile
            if (egg.IsFertile)
            {
                fertiles.Add(egg);
            }
        }
        return fertiles;
    }
}

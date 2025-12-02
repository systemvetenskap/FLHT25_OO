using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace FL_egg;


// i den här klassen lägger vi all kod som styr logik
public class Farm
{
    private List<Egg> _eggs = new();

    public List<Chicken> Chickens { get; set; } = new();
    public Chicken[] Chickens2 { get; set; }
    public List<Coupe> Coupes { get; set; } 


    private void GenerateChickens(int count)
    {
        Chickens2 = new Chicken[count];
        Chicken chicken;
        for (int id = 1; id <= count; id++)
        {
            chicken = new Chicken(id);
            Chickens.Add(chicken);
            Chickens2[id - 1] = chicken;
        }
    }


    public Farm()
    {
        //GenerateChickens(123);
        InitializeCoupes();
        BuyEggs(123);
        HatchAllEggs();
        MoveChickensIntoHouses();
    }

    private void InitializeCoupes()
    {
        Coupes = new List<Coupe>
        {
            new Coupe(2),
            new Coupe(34),
            new Coupe(545),
        };

    }
    public List<Chicken> GetAllCritcallyLowChickens()
    {
        List<Chicken> selected = new();
        foreach (Chicken chicken in Chickens)
        {
            if (chicken.IsCritical())
            {
                selected.Add(chicken);
            }
        }
        return selected;
    }
    private void MoveChickensIntoHouses()
    {
        foreach (Chicken chicken in Chickens.ToList())
        {
            chicken.Eat(-95);
            foreach (Coupe coupe in Coupes)
            {
                if (coupe.TryAddChicken(chicken))
                {
                    // ta bort från Chickens
                    // continue;
                    break;
                }
            }
        }
    }

    public List<Egg> GetAllEggs()
    {
        return _eggs;
    }

    public List<Chicken> HatchAllEggs(int count = 10)
    {
        List<Egg> eggsToRemove = new();
        if (count > _eggs.Count)
        {
            count = _eggs.Count-1;
        }
        //foreach (Egg egg in _eggs.ToList())
        for (int i = 0; i < count; i++)
        {
            Egg egg = _eggs[i];
            Chicken? chicken = egg.Hatch();
            if (chicken is not null)
            {
                Chickens.Add(chicken);
            }
           eggsToRemove.Add(egg);
        }
        
        return Chickens;
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

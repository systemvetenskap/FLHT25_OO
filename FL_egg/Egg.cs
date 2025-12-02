namespace FL_egg;

public class Egg
{
    private static readonly Random _random = new();
    private const double FertilityProbabilityThreshold = 0.9;
    public int Id { get; }
    public bool IsFertile { get; private set; } = false;

    public override string ToString()
    {
        string result = "är fertilt";
        if (!IsFertile)
        {
            result = "är inte fertilt";
        }

        return $"Ägg {Id} {result}";
    }
    public Chicken? Hatch()
    {
        // kolla om ägget är fertilt
        // om så, kläck en kyckling
        if (IsFertile)
        {
            return new Chicken(Id);
        }
        return null;
    }


    public Egg(int eggId)
    {
        Id = eggId;
        IsEggFertile();
    }

    private void IsEggFertile()
    {
        // smart kod för att göra ägget ruttet eller inte
        double probability = _random.NextDouble();
        if (probability < FertilityProbabilityThreshold)
        {
            IsFertile = true;
        }
        else
        {
            IsFertile = false;
        }
    }

    public bool CureEgg()
    {
        // något har hänt. Försök igen
        IsEggFertile();
        return IsFertile;
    }
}

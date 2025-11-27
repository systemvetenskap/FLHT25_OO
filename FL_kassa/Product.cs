using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_kassa;

class Product
{
    // detta är en "hemlig" instansvariabel Fält/field
    string _name = "Apelsin";
    int _countPriceChanges = 0;

    // Vi vill skapa en property
    public string Country { get; set; }
    public bool IsEcological { get; set; } = true;
    public double Price { get; private set; }
    public double Weight { get; set; }
    public string Name { get; set; }

    // har två konstruktorer. En utan parametrar
    public Product()
    {
    }
    // och en som har parameter med ett startvärde
    public Product(double price, string name = "Icas egen")
    {
        // vi tilldelar värdet 
        // name med liten bokstav är indataparameter
        // Name med stor bokstav är vår property/egenskap
        Name = name;
        Price = price;
    }

    // Vi vill ha en metod

    public void SetPrice(double price)
    {
        bool secret = true;
        if (price <= 0)
        {
            return;
        }

        if (_countPriceChanges > 1)
        {
            return; 
        }
        _countPriceChanges++;
        Price = price;
    }

    private void Test()
    {
        
        _countPriceChanges = 0;
    }
}

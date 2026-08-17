using Restoran.Models;

namespace Restoran.Services;

internal class PizzaService : IPizzaService
{
    public Pizza CreatePizza(string name,decimal radius)
    {
       return new Pizza(name,radius);
    }
    public decimal GetBiggestRadiusPizza(Pizza[] pizzas)
    {
        decimal biggestRadius = 0;
        for (int i = 0; i < pizzas.Length; i++)
        {
            if (pizzas[i].Radius > biggestRadius)
            {
                biggestRadius = pizzas[i].Radius;
            }
        }
        return biggestRadius;
    }
}

using Restoran.Models;

namespace Restoran.Services;

internal interface IPizzaService
{
    Pizza CreatePizza(string name,decimal radius);
    decimal GetBiggestRadiusPizza(Pizza[] pizzas);
}

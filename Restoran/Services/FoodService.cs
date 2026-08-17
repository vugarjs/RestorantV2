using Restoran.Models;

namespace Restoran.Services;

public class FoodService : IFoodService
{
    public DateTime WhenWillPrepared(Food food)
    {
        return food.Created + food.PrepareTime;
    }
    public int GetCountByCalories(Food[] foods, decimal n)
    {
        int count = 0;
        for (int i = 0; i < foods.Length; i++)
        {
            if (foods[i].Calori > n)
            {
                count++;
            }
        }
        return count;
    }
}

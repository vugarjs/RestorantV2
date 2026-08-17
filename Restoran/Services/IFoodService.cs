using Restoran.Models;

namespace Restoran.Services;

public interface IFoodService 
{
     DateTime WhenWillPrepared(Food food);
    int GetCountByCalories(Food[] foods, decimal n);
}

using Foodorama.Models;
using System.Collections.Generic;

namespace Foodorama.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
    }
}

using Foodorama.Models;
using System.Collections.Generic;
using System.Linq;

namespace Foodorama.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{ Id = 1, Name = "Sam's Pizza Place"},
                new Restaurant{ Id = 2, Name = "Borger Kung"},
                new Restaurant{ Id = 3, Name = "Posieden's Kibble"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
            _restaurants.Add(restaurant);
            return restaurant;
        }

        List<Restaurant> _restaurants;
    }
}

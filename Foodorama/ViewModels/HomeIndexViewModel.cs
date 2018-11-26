using Foodorama.Models;
using System.Collections.Generic;

namespace Foodorama.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
    }
}

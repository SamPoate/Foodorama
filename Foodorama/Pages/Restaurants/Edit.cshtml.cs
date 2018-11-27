using Foodorama.Models;
using Foodorama.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Foodorama.Pages.Restaurants
{
    [Authorize]
    public class EditModel : PageModel
    {
        private IRestaurantData _restaurantData;

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public EditModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        public IActionResult OnGet(int id)
        {
            Restaurant = _restaurantData.Get(id);
            if (Restaurant == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _restaurantData.Update(Restaurant);
                return RedirectToAction("Details", "Home", new {id = Restaurant.Id});
            }
            else
            {
                return Page();
            }
        }
    }
}
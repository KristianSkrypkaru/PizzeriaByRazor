using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzeriaByRazor.Models;

namespace PizzeriaByRazor.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPirce { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            PizzaPirce = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPirce += 1;
            if (Pizza.Cheese) PizzaPirce += 1;
            if (Pizza.Peperoni) PizzaPirce += 1;
            if (Pizza.Mushroom) PizzaPirce += 1;
            if (Pizza.Tuna) PizzaPirce += 1;
            if (Pizza.Pineapple) PizzaPirce += 7;
            if (Pizza.Ham) PizzaPirce += 1;
            if (Pizza.Beef) PizzaPirce += 1;
            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPirce});
        }
    }
}

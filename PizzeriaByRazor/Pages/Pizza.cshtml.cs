using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzeriaByRazor.Models;

namespace PizzeriaByRazor.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> PizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle = "Margarita", PizzaName = "Margarita", BasePrice = 7, TomatoSauce = true, Cheese = true, Beef = true, FinalPrice = 5},
            new PizzasModel(){ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 7, TomatoSauce = true, Cheese = true, Ham = true, Pineapple = true, FinalPrice = 15},
            new PizzasModel(){ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 7, TomatoSauce = true, Cheese = true, Ham = true, Mushroom = true, FinalPrice = 9},
            new PizzasModel(){ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 7, TomatoSauce = true, Cheese = true, Ham = true, Beef = true, FinalPrice = 9},
            new PizzasModel(){ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 7, TomatoSauce = true, Cheese = true, Mushroom = true,FinalPrice = 8},
            new PizzasModel(){ImageTitle = "Papperoni", PizzaName = "Papperoni", BasePrice = 7, TomatoSauce = true, Cheese = true, Peperoni = true, FinalPrice = 12},
            new PizzasModel(){ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 7, TomatoSauce = true, Cheese = true, Tuna = true,FinalPrice = 14},
            new PizzasModel(){ImageTitle = "Vegeterian", PizzaName = "Vegeterian", BasePrice = 7, TomatoSauce = true, Cheese = true, Mushroom = true, Pineapple = true, FinalPrice = 10},
            
        };

        public void OnGet()
        {
        }
    }
}

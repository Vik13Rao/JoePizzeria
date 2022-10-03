using JoePizzeria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JoePizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> mockPizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageUrl="chicsupreme", PizzaName="Chicken Supreme", FinalPrice=200,OrderId=0001},
            new PizzasModel(){ImageUrl="kebab", PizzaName="Chicken Kebab", FinalPrice=230,OrderId=0002 },
            new PizzasModel(){ImageUrl="mexicana", PizzaName="Chicken Mexicana", FinalPrice=250,OrderId=0003 },
            new PizzasModel(){ImageUrl="nystyle", PizzaName="NewYork Style", FinalPrice=150,OrderId=0004 },
            new PizzasModel(){ImageUrl="pepperoni", PizzaName="Pepperoni", FinalPrice=300,OrderId=0005 },
            new PizzasModel(){ImageUrl="perichic", PizzaName="Chicken PeriPeri", FinalPrice=280,OrderId=0006 },
            new PizzasModel(){ImageUrl="tomato", PizzaName="Tomato & Basil", FinalPrice=180,OrderId=0007 }
            
        };
        public void OnGet()
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JoePizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class ThankYouModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageUrl { get; set; }
        public float FinalPrice { get; set; }
        public float OrderId { get; set; }



        public void OnGet()
        {
        }
    }
}

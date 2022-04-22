using Lotiques.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lotiques.Pages.Forms
{
    public class SpecialAntiquesModel : PageModel
    {
        [BindProperty]
        public Antique Antique { get; set; }

        public float Price { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Price = Antique.BasePrice;
            if (Antique.HandMade) Price += 5;
            if (Antique.Printed) Price += 3;

            return RedirectToPage("/CheckOut/CheckOut", new { Antique.Name, Price });
        }
    }
}

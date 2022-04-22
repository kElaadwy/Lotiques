using Lotiques.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lotiques.Pages
{
    public class AntiquesModel : PageModel
    {
        public List<Antique> DB = new List<Antique>()
        {
            new Antique()
            {
                Name = "Vase",
                ImageTitle = "2.jpg",
                Color = "brown",
                Material = "glass",
                HandMade = true,
                FinalPrice = 15.0f
            },
            new Antique()
            {
                Name = "Writing machien",
                ImageTitle = "3.jpeg",
                Color = "brown",
                Material = "wood",
                HandMade = true,
                FinalPrice = 15.0f
            },
            new Antique()
            {
                Name = "Horse",
                ImageTitle = "4.jpg",
                Color = "silver",
                Material = "metal",
                Printed = true,
                FinalPrice = 13.0f
            },
            new Antique()
            {
                Name = "Phone",
                ImageTitle = "5.jpg",
                Color = "white",
                Material = "cuppor",
                FinalPrice = 10.0f
            },

        };
        public void OnGet()
        {
        }
    }
}

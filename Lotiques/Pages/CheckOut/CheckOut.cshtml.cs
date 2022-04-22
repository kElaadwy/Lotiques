using Lotiques.Data;
using Lotiques.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lotiques.Pages.CheckOut
{
    [BindProperties(SupportsGet = true)]
    public class CheckOutModel : PageModel
    {
        public string Name{ get; set; }
        public float Price { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckOutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (String.IsNullOrEmpty(Name)) Name = "No name";
            if (String.IsNullOrEmpty(ImageTitle)) ImageTitle = "1.jpg";

            AntiqueOrder antiqueOrder = new AntiqueOrder();
            antiqueOrder.Name = Name;
            antiqueOrder.BasePrice = Price;

            _context.Add(antiqueOrder);
            _context.SaveChanges();
        }
    }
}

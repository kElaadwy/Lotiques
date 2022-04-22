using Lotiques.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lotiques.Models;

namespace Lotiques.Pages
{
    public class OrderedModel : PageModel
    {
        public List<AntiqueOrder> Orders = new List<AntiqueOrder>();

        ApplicationDbContext _context;
        public OrderedModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Orders = _context.AntiqueOrders.ToList();
        }
    }
}

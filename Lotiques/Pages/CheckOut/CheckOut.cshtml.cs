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



        public void OnGet()
        {
            if (String.IsNullOrEmpty(Name)) Name = "No name";
            if (String.IsNullOrEmpty(ImageTitle)) ImageTitle = "1.jpg";
        }
    }
}

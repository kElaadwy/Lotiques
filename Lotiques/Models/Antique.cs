namespace Lotiques.Models
{
    public class Antique
    {
        public string ImageTitle { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public float BasePrice { get; set; } = 10.0f;
        public bool HandMade { get; set; }
        public bool Printed { get; set; }
        public float FinalPrice { get; set; }


    }
}

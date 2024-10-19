namespace Recipie_Management_App.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public string Category { get; set; }  // New property for category
        public string ImageUrl { get; set; } // Existing property
    }

}

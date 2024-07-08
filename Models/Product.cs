namespace ProductsManagement.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Initialize with empty string
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty; // Initialize with empty string
    }
}
namespace WebApplication1_HW_22_11_2024.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string? Description {  get; set; }
        public decimal Price { get; set; }
    }
}

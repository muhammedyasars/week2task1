namespace week2task1.Models // ✅ Ensure it's "Models", not "Model"
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}

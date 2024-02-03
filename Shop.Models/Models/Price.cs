namespace Shop.Models
{
    public class Price
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public double Value { get; set; }
        public int ProductId { get; set; }
    }
}


namespace Shop.Models
{
    public class Price
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Value { get; set; }
    }
}


namespace Shop.Models.Responses
{
    public class AddPriceResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Value { get; set; }
    }
}

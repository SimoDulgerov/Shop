using Shop.Models.Responses;

namespace Shop.BL.Survices
{
    internal class PriceResponse : AddPriceResponse
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
    }
}
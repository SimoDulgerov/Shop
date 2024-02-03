namespace Shop.Models.SS
{
    public record Product
    {   
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
    }
}

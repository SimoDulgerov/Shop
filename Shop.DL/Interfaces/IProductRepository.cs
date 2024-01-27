using Shop.Models.SS;

namespace Shop.DL
{
    public interface IProductRepository
    {
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(Product product);
    }
}

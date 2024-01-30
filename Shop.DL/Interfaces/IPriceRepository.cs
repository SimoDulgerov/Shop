using Shop.Models;

namespace Shop.DL.Interfaces
{
    public interface IPriceRepository
    {
        List<Price> GetAll();
        void Add(Price price);
        void Update(Price price);
        void Delete(Price price);
        void AddPrice(Price newPrice);
    }
}

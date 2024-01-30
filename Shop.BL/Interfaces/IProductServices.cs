using Shop.Models.Request;
using Shop.Models.Responses;

namespace Shop.BL.Interfaces
{
    public interface IProductServices
    {
        ProductResponse AddProduct(ProductRequest request);
    }
}

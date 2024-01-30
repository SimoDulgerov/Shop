using Shop.BL.Interfaces;
using Shop.DL;
using Shop.Models.Request;
using Shop.Models.Responses;
using Shop.Models.SS;

namespace Shop.BL.Survices
{
    public class ProductService : IProductServices
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductResponse AddProduct(ProductRequest request)
        {
            // Валидация и бизнес логика
            var newProduct = new Product { Name = request.Name, Price = request.Price };
            _productRepository.AddProduct(newProduct);

            return new ProductResponse { Id = newProduct.Id, Name = newProduct.Name };
        }
    }
}

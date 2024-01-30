using Shop.BL.Interfaces;
using Shop.DL.Interfaces;
using Shop.Models;
using Shop.Models.Request;
using Shop.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.Survices
{
    public class PriceService : IPriceService
    {
        private readonly IPriceRepository _priceRepository;

        public PriceService(IPriceRepository priceRepository)
        {
            _priceRepository = priceRepository;
        }

        public AddPriceResponse AddPrice(AddPriceResponse request)
        {
            var newPrice = new Price { ProductName = request.ProductName, Value = request.Value };
            _priceRepository.AddPrice(newPrice);

            return new PriceResponse { Id = newPrice.Id, ProductName = newPrice.ProductName };
        }

        public AddPriceResponse AddPrice(AddPriceRequest request)
        {
            throw new NotImplementedException();
        }

    }
}


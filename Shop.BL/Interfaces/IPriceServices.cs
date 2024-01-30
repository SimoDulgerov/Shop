using Shop.Models.Request;
using Shop.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BL.Interfaces
{
    public interface IPriceService
    {
        AddPriceResponse AddPrice(AddPriceRequest request);
        
    }
}

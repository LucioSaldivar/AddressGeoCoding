using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressApi.Models;

namespace AddressApi.Services
{
    public class AddressService : IAddressService
    {
        public List<AddressModel> GetPayments(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<int> SavePayment(PaymentRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

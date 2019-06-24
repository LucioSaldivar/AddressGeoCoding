using AddressApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressApi.Services
{
    public interface IAddressService
    {
        Task<int> SavePayment(PaymentRequest request);
        List<AddressModel> GetPayments(int orderId);
    }
}

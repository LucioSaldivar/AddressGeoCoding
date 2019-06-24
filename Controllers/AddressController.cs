using AddressApi.Models;
using AddressApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace AddressApi.Controllers
{
    [RoutePrefix("api/Address")]
    public class AddressController : ApiController
    {
        public IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        /// <summary>
        /// Get all payments for specific orderid
        /// </summary>
        /// <param name="paymentId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ICollection<AddressModel>> GetPayments(int orderId)
        {
            var response = _addressService.GetPayments(orderId);
            return response;
        }

        /// <summary>
        /// Save payment for specific orderid
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IHttpActionResult> SavePayment(PaymentRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var paymentId = await _addressService.SavePayment(request);
            return Ok(new { Id = paymentId });
        }
    }
}
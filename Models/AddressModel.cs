using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressApi.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}

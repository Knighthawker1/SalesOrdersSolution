using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesOrdersProject.Models
{
    public class ShippingInfo
    {
        [Required(ErrorMessage = "The shipping address field is mandatory")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The shipping city field is mandatory")]
        public string City { get; set; }

        [Required(ErrorMessage = "The shipping state field is mandatory")]
        public string State { get; set; }

        [Required(ErrorMessage = "The shipping postal code field is mandatory")]
        public string PostalCode { get; set; }
    }
}
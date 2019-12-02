using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesOrdersProject.Models
{
    public class PartialClasses
    {
        [MetadataType(typeof(CustomerMetadata))]
        public partial class Customer
        {
        }

        [MetadataType(typeof(OrderMetadata))]
        public partial class Order
        {
        }
    }
}
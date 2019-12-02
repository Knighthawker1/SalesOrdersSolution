using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesOrdersProject.Models
{
    public class CustomerMetadata
    {
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string FirstName;

        [StringLength(25)]
        [Display(Name = "Last Name")]
        public string LastName;

        [StringLength(50)]
        [Display(Name = "Street Address")]
        public string CustomerStreetAddress;

        [StringLength(30)]
        [Display(Name = "City")]
        public string CustomerCity;

        [StringLength(2)]
        [Display(Name = "State")]
        public string CustomerState;

        [StringLength(10)]
        [Display(Name = "Zip Code")]
        public string CustomerZipCode;

        [StringLength(3)]
        [Display(Name = "Area Code")]
        public string CustomerAreaCode;

        [StringLength(8)]
        [Display(Name = "Phone Number")]
        public string CustomerPhoneNumber;

        [StringLength(50)]
        [Display(Name = "Billing Address")]
        public string BillingAddress;

        [StringLength(30)]
        [Display(Name = "Billing City")]
        public string BillingCity;

        [StringLength(2)]
        [Display(Name = "Billing State")]
        public string BillingState;

        [StringLength(10)]
        [Display(Name = "Billing Postal Code")]
        public string BillingPostalCode;

        [StringLength(20)]
        [Display(Name = "Credit Card Number")]
        public string BillingCreditCardNumber;

        [StringLength(12)]
        [Display(Name = "Expiration Month")]
        public string BillingExpireMonth;

        [StringLength(4)]
        [Display(Name = "Expiration Year")]
        public string BillingExpireYear;

        [StringLength(100)]
        [Display(Name = "Email Address")]
        public string CustomerEmailAddress;

        [StringLength(50)]
        [Display(Name = "Password")]
        public string CustomerPassword;
    }

    public class OrderMetadata
    {
        [StringLength(50)]
        [Display(Name = "Shipping Address")]
        public string ShippingAddress;

        [StringLength(30)]
        [Display(Name = "Shipping City")]
        public string ShippingCity;

        [StringLength(2)]
        [Display(Name = "Shipping State")]
        public string ShippingState;

        [StringLength(10)]
        [Display(Name = "Shipping Postal Code")]
        public string ShippingPostalCode;
    }
}
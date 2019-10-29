using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesOrdersProject.Models
{
    public class BillingInfo
    {
        [Required(ErrorMessage = "The first name field is mandatory")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The last name field is mandatory")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The credit card number field is mandatory")]
        public string CreditCardNumber { get; set; }

        [Required(ErrorMessage = "The billing address field is mandatory")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The billing city field is mandatory")]
        public string City { get; set; }

        [Required(ErrorMessage = "The billing state field is mandatory")]
        public string State { get; set; }

        [Required(ErrorMessage = "The billing zip code field is mandatory")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "The billing expire month field is mandatory")]
        public string ExpireMonth { get; set; }

        public SelectList Months()
        {
            return new SelectList(new string[]
            {
                "01", "02", "03", "04",
                "05", "06", "07", "08",
                "09", "10", "11", "12"
            });
        }

        [Required(ErrorMessage = "The billing expire year field is mandatory")]
        public string ExpireYear { get; set; }

        public SelectList Years()
        {
            int currentYear = DateTime.Now.Year;

            return new SelectList(new string[]
            {
                "2019", "2020", "2021", "2022",
                "2023", "2024", "2025", "2026",
                "2027", "2028", "2029", "2030"
            });
        }
    }
}
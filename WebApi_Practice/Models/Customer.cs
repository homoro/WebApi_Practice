using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi_Practice.Models
{
    public partial class Customer
    {
        public Customer()
        {
            
        }

        public int CustomerId { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        
    }
}

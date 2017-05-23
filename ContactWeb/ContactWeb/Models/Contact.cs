using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactWeb.Models
{
    public class Contact
    {
        [Key]
        [Required]
        public int ContactId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhonePrimary { get; set; }
        public string PhoneSecondary { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string Zip { get; set; }
    }
}
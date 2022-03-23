using System;
using System.ComponentModel.DataAnnotations;
using Fare;

namespace InvoiceApp.Models
{
    public class Client
    {
        public string ClientId{ get; set; } = GenerateID.GenerateClientID();
        public string InvoiceId { get; set; }
        [Required]
        public string ClientName { get; set; }
        [Required]
        public string ClientEmail { get; set; }
        [Required]
        public string ClientAddress { get; set; }
        [Required]
        public string ClientCity { get; set; }
        [Required]
        public string ClientCountry { get; set; }
        [Required]
        public string ClientPostal { get; set; }

        
    }
}

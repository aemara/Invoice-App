using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApp.Models
{
    public class InputModel
    {
        [Required]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime InvoiceDate { get; set; }

        public string PaymentTerms { get; set; }
        public DateTime PaymentDue { get; set; }


        public Client Client { get; set; }


        public List<InvoiceItem> Items { get; set; } = new List<InvoiceItem>(16);


        [Required]
        public string BillFromName { get; set; }
        [Required]
        public string BillFromEmail { get; set; }
        [Required]
        public string BillFromAddress { get; set; }
        [Required]
        public string BillFromCity { get; set; }
        [Required]
        public string BillFromCountry { get; set; }
        [Required]
        public string BillFromPostal { get; set; }


        public void PopulateItems()
        {
            for (int i = 0; i < Items.Capacity; i++)
            {
                Items.Add(new InvoiceItem());
            }
        }
    }
}

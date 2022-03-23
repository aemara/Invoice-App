using System;
using System.Collections.Generic;
namespace InvoiceApp.Models
{
    public class Invoice
    {
        public string InvoiceId { get; set; } = GenerateID.GenerateInvoiceID();
        public string Description { get; set; }
        public List<InvoiceItem> Items { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string PaymentTerms { get; set; }
        public DateTime PaymentDue { get; set; }
        public int TotalPrice { get; set; }
        public string Status { get; set; } = "pending";
        public Client Client { get; set; }



        public string BillFromName { get; set; }
        public string BillFromEmail { get; set; }
        public string BillFromAddress { get; set; }
        public string BillFromCity { get; set; }
        public string BillFromCountry { get; set; }
        public string BillFromPostal { get; set; }


        public int GetTotalPrice()
        {
            int totalItemPrice;
            int totalInvoicePrice = 0;

            foreach (var item in Items)
            {
                totalItemPrice = item.Quantity * item.Price;
                totalInvoicePrice += totalItemPrice;
            }

            TotalPrice = totalInvoicePrice;
            return TotalPrice;
        }


        
    }
}

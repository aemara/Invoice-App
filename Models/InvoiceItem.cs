using System;
using Fare;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApp.Models
{
    
    public class InvoiceItem
    {
        public string InvoiceItemId { get; set; }
        public string InvoiceId { get; set; } = "";
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public InvoiceItem() {
            InvoiceItemId = GenerateID.GenerateItemID();
        }

        public InvoiceItem(string itemName, int quantity, int price)
        {
            Name = itemName;
            Quantity = quantity;
            Price = price;
        }

        



    }
}

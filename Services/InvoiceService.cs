using System;
using System.Collections.Generic;
using Fare;
using InvoiceApp.Models;
using InvoiceApp.Pages;
namespace InvoiceApp.Services
{
    public class InvoiceService
    {
       
        public void AddInvoice(InputModel input)
        {
            Invoice invoice = new Invoice();
            input.Client.InvoiceId = invoice.InvoiceId;

            //The following code could be put into a method inside InputModel
            //and an invoice object could be passed as an argument to it.
            invoice.Description = input.Description;
            invoice.Items = input.Items;
            invoice.InvoiceDate = input.InvoiceDate;
            invoice.PaymentTerms = input.PaymentTerms;
            invoice.Client = input.Client;

            invoice.BillFromName = input.BillFromName;
            invoice.BillFromEmail = input.BillFromEmail;
            invoice.BillFromAddress = input.BillFromAddress;
            invoice.BillFromCity = input.BillFromCity;
            invoice.BillFromCountry = input.BillFromCountry;
            invoice.BillFromPostal = input.BillFromPostal;
           
            IndexModel.invoices.Add(invoice);
        }

        public void EditInvoice(InputModel input, string id)
        {
            Invoice invoice = IndexModel.invoices.Find(invoice => invoice.InvoiceId == id);

            //The following code could be put into a method inside InputModel
            //and an invoice object could be passed as an argument to it.
    
            invoice.Items = input.Items;

            invoice.Description = input.Description;
            invoice.InvoiceDate = input.InvoiceDate;
            invoice.PaymentTerms = input.PaymentTerms;
            invoice.Client = input.Client;

            invoice.BillFromName = input.BillFromName;
            invoice.BillFromEmail = input.BillFromEmail;
            invoice.BillFromAddress = input.BillFromAddress;
            invoice.BillFromCity = input.BillFromCity;
            invoice.BillFromCountry = input.BillFromCountry;
            invoice.BillFromPostal = input.BillFromPostal;


        }

        public void DeleteInvoice(string id)
        {
            IndexModel.invoices.Remove(IndexModel.invoices.Find(item => item.InvoiceId == id));
        }
      

        public void EditStatus(string id) {
            Invoice invoice = IndexModel.invoices.Find(invoice => invoice.InvoiceId == id);
            invoice.Status = "Paid";

        }




    }
}

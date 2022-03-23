using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InvoiceApp.Models;
using InvoiceApp.Pages;

using Microsoft.EntityFrameworkCore;
using InvoiceApp.Services;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApp.Pages
{
    public class EditInvoiceModel : PageModel
    {

       
        public readonly InvoiceService _service;

        [BindProperty]
        public InputModel Input { get; set; }

        public string InvoiceId { get; set; }
        public string IsDeleteItem { get; set; }

        public EditInvoiceModel(InvoiceService service)
        {
            _service = service;
        }

        
        public async void OnGet(string id)
        {
            Invoice invoice = IndexModel.invoices.Find(invoice => invoice.InvoiceId == id);
            InvoiceId = invoice.InvoiceId;
            Input = new InputModel();


            //The following code could be put into a method inside InputModel
            //and the above invoice object could be passed as an argument to it.
            Input.Items = invoice.Items;

            Input.BillFromAddress = invoice.BillFromAddress;
            Input.BillFromCity = invoice.BillFromCity;
            Input.BillFromPostal = invoice.BillFromPostal;
            Input.BillFromCountry = invoice.BillFromCountry;

            Input.Client = invoice.Client;

            Input.InvoiceDate = invoice.InvoiceDate;
            Input.PaymentTerms = invoice.PaymentTerms;
            Input.Description = invoice.Description;

        }

        public  async Task<IActionResult> OnPost(string id)
        {
            _service.EditInvoice(Input, id);
            return RedirectToPage("/ViewInvoice", new {id = id });
        }

    }
}

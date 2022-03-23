using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InvoiceApp.Models;
using Microsoft.EntityFrameworkCore;
using InvoiceApp.Services;

namespace InvoiceApp.Pages
{
    public class ViewInvoiceModel : PageModel
    {
        public Invoice Invoice { get; set; }
        public List<InvoiceItem> ItemList { get; set; }

       
        public readonly InvoiceService _service;

        public ViewInvoiceModel(InvoiceService service)
        {
            _service = service;
        }


        public IActionResult OnGet(string id)
        {
            
            Invoice = IndexModel.invoices.Find(invoice => invoice.InvoiceId == id);
            if(Invoice is null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPostDelete(string id)
        {
            _service.DeleteInvoice(id);
            return RedirectToPage("/index");
        }

        public IActionResult OnPostPaid(string id)
        {
            _service.EditStatus(id);
            return RedirectToPage("/ViewInvoice", new { id = id });


        }
    }
}

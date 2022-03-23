using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using InvoiceApp.Models;



namespace InvoiceApp.Pages
{
    public class IndexModel : PageModel
    {
       
       
        public static List<Invoice> invoices = new List<Invoice>();


        public static List<Invoice> Invoices
        {
            get { return invoices; }
            set { invoices = value; }
        }

        public int NumOfInvoices { get; set; }

       

        public async void OnGet()
        {
            //invoices = await _context.Invoices.ToListAsync();

            
        }

        public void OnPostFilter(string input)
        {
        }



        public int getNumOfInvoices()
        {
            NumOfInvoices = invoices.Count;
            return NumOfInvoices;
        }
    }
}
 
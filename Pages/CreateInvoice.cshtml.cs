using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InvoiceApp.Models;
using Fare;
using System.ComponentModel.DataAnnotations;
using InvoiceApp.Services;

namespace InvoiceApp.Pages
{
    public class CreateInvoiceModel : PageModel
    {
        
        public readonly InvoiceService _service;
     

        [BindProperty]
        public InputModel Input { get; set; }

        public CreateInvoiceModel(InvoiceService service)
        {
            
            _service = service;
        }


        public void OnGet()
        {
            Input = new InputModel();
            Input.PopulateItems();

        }
        

        public async Task<IActionResult> OnPost()
        {

            _service.AddInvoice(Input);
            return RedirectToPage("/Index");

        }



    }
}

using System;
using Fare;

namespace InvoiceApp.Models
{
    public static class GenerateID
    {
        public static string GenerateInvoiceID()
        {
            Xeger xeger = new Xeger("[A-Z][A-Z][0-9]{4}", new Random());
            return xeger.Generate();
        }

        public static string GenerateClientID()
        {
            Xeger xeger = new Xeger("[0-9]{6}", new Random());
            return xeger.Generate();
        }

        public static string GenerateItemID()
        {
            Xeger xeger = new Xeger("[0-9]{10}", new Random());
            return xeger.Generate();
        }
    }
}

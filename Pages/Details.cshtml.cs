using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmxDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HtmxDemo.Pages
{
    public class DetailsModel : PageModel
    {
        public Customer customer { get; set; }

        public void OnGet(int customerId)
        {
            SimulateDB simulateDB = new();
            customer = simulateDB.GetCustomer(customerId);
        }
    }
}

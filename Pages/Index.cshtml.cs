using HtmxDemo.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HtmxDemo.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<CustomerModel> data { get; set; }
        
        public class CustomerModel
        {
            public int Id { get; set; }

            public String Name { get; set; }
        }

        public void OnGet()
        {
            SimulateDB simulateDb = new();
            List<Customer> customers = simulateDb.GetCustomers();
            List<CustomerModel> models = new();
            foreach (var c in customers)
            {
                models.Add(new CustomerModel
                {
                    Id = c.Id,
                    Name = c.Name
                });
            }
            data = models;
        }
    }
}

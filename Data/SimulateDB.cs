using System;
using System.Collections.Generic;
using System.Linq;

namespace HtmxDemo.Data
{
    //class simulating db and reading data from the database
    public class SimulateDB
    {
        public SimulateDB() { }
        private List<Customer> customers = new()
        {
            new Customer
            {
                Id = 1,
                Name = "Happiness Ncube",
                Address = "Domboshava, Zimbabwe",
                Telephone = "0777 000 000"
            },
            new Customer
            {
                Id = 2,
                Name = "John Doe",
                Address = "Harare, Zimbabwe",
                Telephone = "0888 000 000"
            },
            new Customer
            {
                Id = 3,
                Name = "Moses Dube",
                Address = "Bulawayo, Zimbabwe",
                Telephone = "0999 000 000"
            },
            new Customer
            {
                Id = 4,
                Name = "John Mike",
                Address = "Gweru, Zimbabwe",
                Telephone = "0666 000 000"
            },
            new Customer
            {
                Id = 5,
                Name = "Mike Ndlovu",
                Address = "Mutare, Zimbabwe",
                Telephone = "0555 000 000"
            },
            new Customer
            {
                Id = 6,
                Name = "Itai Gondo",
                Address = "Kwekwe, Zimbabwe",
                Telephone = "0777 000 000"
            }
        };

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public Customer GetCustomer(int id)
        {
            return customers.First(i => i.Id == id);
        }
    }

    public class Customer
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Address { get; set; }

        public String Telephone { get; set; }
    }

}

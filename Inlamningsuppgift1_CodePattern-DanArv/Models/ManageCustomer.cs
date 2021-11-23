using Inlamningsuppgift1_CodePattern_StevenErixon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_StevenErixon.Models
{
    public class ManageCustomer : IManageCustomer
    {

        private readonly ICustomer _customer;

        public ManageCustomer(ICustomer customer)
        {
            _customer = customer;
        }

        public ICustomer CreateCustomer()
        {
            bool programIsRunning = true;
            while (programIsRunning)
            {
                Console.WriteLine("Enter name:");
                _customer.Name = Console.ReadLine();
                Console.WriteLine("Enter phonenumber:");
                _customer.PhoneNumber = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(_customer.Name) || !String.IsNullOrWhiteSpace(_customer.PhoneNumber))
                {
                    programIsRunning = false;
                    return _customer;
                }
                else
                {
                    Console.WriteLine("Please enter valid information");
                }
            }
            return null;
        }

        public void SeeAllCustomers(List<ICustomer> customers)
        {
            foreach(var _customer in customers)
            {
                Console.WriteLine($"Name: {_customer.Name}; Phonenumber: {_customer.PhoneNumber}");
            }
        }
    }
}

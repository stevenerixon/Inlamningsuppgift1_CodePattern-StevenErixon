using Inlamningsuppgift1_CodePattern_StevenErixon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_StevenErixon.Models
{
    public class CreateCustPetList : ICreateCustPetList
    {
        public List<ICustomer> CreateCustomerList()
        {
            List<ICustomer> customers = new List<ICustomer>
            {
                new Customer { Name = "Steven", PhoneNumber = "0706498321"},
                new Customer {Name = "Daniel", PhoneNumber = "0727218651"}
            };
            return customers;
        }

        public List<IPet> CreatePetList(List<ICustomer> owner)
        {
            List<IPet> pets= new List<IPet>
            {
                new Pet { Name = "Freija", Owner = (Customer)owner[0], inKennel = true},
                new Pet{Name = "Yra", Owner = (Customer)owner[1], inKennel = true}
            };
            return pets;
        }
    }
}

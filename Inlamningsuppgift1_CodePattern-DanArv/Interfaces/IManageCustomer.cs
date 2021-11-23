using Inlamningsuppgift1_CodePattern_StevenErixon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_StevenErixon
{
    public interface IManageCustomer
    {
        ICustomer CreateCustomer();
        void SeeAllCustomers(List<ICustomer> customers);
    }
}

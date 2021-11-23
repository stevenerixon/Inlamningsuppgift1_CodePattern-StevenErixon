using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_StevenErixon.Interfaces
{
    public interface IMainMenu
    {
        void ShowMainMenu(List<ICustomer> customers, List<IPet> pets);
    }
}

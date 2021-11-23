using Inlamningsuppgift1_CodePattern_StevenErixon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_StevenErixon
{
    public class Application : IApplication
    {
        private readonly IMainMenu _mainMenu;
        private readonly ICreateCustPetList _custPetList;

        List<ICustomer> customers;
        List<IPet> pets;

        public Application(IMainMenu mainMenu, ICreateCustPetList custPetList)
        {
            _mainMenu = mainMenu;
            _custPetList = custPetList;
        }
        public void Run()
        {
            customers = _custPetList.CreateCustomerList();
            pets = _custPetList.CreatePetList(customers);

            _mainMenu.ShowMainMenu(customers, pets);
        }
    }
}

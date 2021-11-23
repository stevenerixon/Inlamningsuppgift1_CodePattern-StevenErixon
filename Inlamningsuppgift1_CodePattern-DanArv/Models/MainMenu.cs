using Inlamningsuppgift1_CodePattern_StevenErixon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_StevenErixon
{
    public class MainMenu : IMainMenu
    {
        private readonly IManageCustomer _manageCustomer;
        private readonly IManagePet _managePet;
        private readonly IKennelManagement _kennelManagement;

        public MainMenu(IManageCustomer manageCustomer, IManagePet managePet, IKennelManagement kennelManagement)
        {
            _manageCustomer = manageCustomer;
            _managePet = managePet;
            _kennelManagement = kennelManagement;
        }

        public void ShowMainMenu(List<ICustomer> customers, List<IPet> pets)
        {
            bool progrmaIsRunning = true;
            while (progrmaIsRunning)
            {
                Console.WriteLine("Welcome to Kennel Management");
                Console.WriteLine("****************************");
                Console.WriteLine("Press the following buttons to continue in the program:");
                Console.WriteLine("[1]Add customer");
                Console.WriteLine("[2]Add a pet");
                Console.WriteLine("[3]Check in a pet");
                Console.WriteLine("[4]Check out a pet");
                Console.WriteLine("[5]See all registered customers");
                Console.WriteLine("[6]See all registered pets");
                Console.WriteLine("[7]Checked in pets and their owners");
                Console.WriteLine("[0]Exit application");

                string userChoise = Console.ReadLine();
                if (userChoise != "1" && userChoise != "2" && userChoise != "3" && userChoise != "4" && userChoise != "5" && userChoise != "6" && userChoise != "7" && userChoise != "0")
                {
                    Console.WriteLine("Invalig option");
                }
                else
                {
                    switch (userChoise)
                    {
                        case "1":
                            Console.Clear();
                            customers.Add(_manageCustomer.CreateCustomer());
                            break;

                        case "2":
                            Console.Clear();
                            pets.Add(_managePet.CreatePet(customers));
                            break;

                        case "3":
                            Console.Clear();
                            _kennelManagement.CheckInPet(pets);
                            break;

                        case "4":
                            Console.Clear();
                            _kennelManagement.CheckOutPet(pets);
                            break;

                        case "5":
                            Console.Clear();
                            _manageCustomer.SeeAllCustomers(customers);
                            break;

                        case "6":
                            Console.Clear();
                            _managePet.SeeAllPets(pets);
                            break;

                        case "7":
                            Console.Clear();
                            _kennelManagement.SeePetsInKennel(pets);
                            break;

                        case "0":
                            progrmaIsRunning = false;
                            break;

                        default:
                            // need code?
                            break;

                    }
                }
            }
        }
    }
}

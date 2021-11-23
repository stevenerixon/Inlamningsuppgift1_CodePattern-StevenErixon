using Inlamningsuppgift1_CodePattern_StevenErixon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_StevenErixon.Models
{
    public class ManagePet : IManagePet
    {
        private readonly IPet _pet;

        public ManagePet(IPet pet)
        {
            _pet = pet;
        }

        public IPet CreatePet(List<ICustomer> owners)
        {
            bool programIsRunning = true;
            while (programIsRunning)
            {
                Console.WriteLine("Enter pets name");
                _pet.Name = Console.ReadLine();
                if (!String.IsNullOrEmpty(_pet.Name))
                {
                    Console.WriteLine("Enter owners name");
                    string userInput = Console.ReadLine();

                    ICustomer customer = owners.FirstOrDefault(name => name.Name == userInput);
                    if(owners != null)
                    {
                        _pet.Owner = customer;
                        Console.WriteLine("Pet added.");
                        programIsRunning = false;
                        return _pet;
                    }
                    else
                    {
                        Console.WriteLine("Owner not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter your pets name");
                }
            }
            return null;
        }

        public void SeeAllPets(List<IPet> pets)
        {
            foreach (var _pet in pets)
            {
                Console.WriteLine($"Name: {_pet.Name}, Atkennel: {_pet.inKennel}");
            }
        }
    }
}

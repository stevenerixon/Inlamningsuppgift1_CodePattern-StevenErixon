using Inlamningsuppgift1_CodePattern_StevenErixon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_StevenErixon.Models
{
    public class KennelMannagement : IKennelManagement
    {
        private readonly IGetPrice _getPrice;
        private readonly IKennelServices _kennelServices;

        public KennelMannagement(IGetPrice getPrice, IKennelServices kennelServices)
        {
            _getPrice = getPrice;
            _kennelServices = kennelServices;
        }

        public void SeePetsInKennel(List<IPet> pets)
        {
            IEnumerable<IPet> query = pets.Where(pet => pet.inKennel == true);
            Console.WriteLine($"{query.Count()} animals in the kennel at the moment");
            foreach(IPet pet in query)
            {
                Console.WriteLine($"{pet.Name} Owner:{pet.Owner.Name}, Owners phonenumber: {pet.Owner.PhoneNumber}");
            }
        }
        public void CheckInPet(List<IPet> pets)
        {
            Console.WriteLine("Enter name of pet you want to check in:");
            string inputPetName = Console.ReadLine();
            if (inputPetName !=null)
            {
                IPet pet = pets.FirstOrDefault(name => name.Name == inputPetName);
                if(pet != null)
                {
                    pet.inKennel = true;

                    _kennelServices.ClawTrimPet((Pet)pet);
                    _kennelServices.WashPet((Pet)pet);

                    Console.WriteLine($"Your pet {pet.Name} just checked in");
                }
                else
                {
                    Console.WriteLine("Pet not found");
                }
            }
        }

        public void CheckOutPet(List<IPet> pets)
        {
            Console.WriteLine("Enter the name of the pet you want to check out:");
            string inputPetName = Console.ReadLine();
            if(inputPetName != null)
            {
                IPet pet = pets.FirstOrDefault(name => name.Name == inputPetName);
                if(pet != null)
                {
                    pet.inKennel = false;

                    _getPrice.TotalPrice((Pet)pet);

                    Console.WriteLine($"Your pet {pet.Name} is now checked out");
                }
                else
                {
                    Console.WriteLine("Pet not found");
                }
            }
        }
    }
}

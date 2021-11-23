using Inlamningsuppgift1_CodePattern_StevenErixon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_StevenErixon.Models
{
    public class KennelServices : IKennelServices
    {
        public void ClawTrimPet(Pet pet)
        {
            Console.WriteLine("Does your pet need a claw trim? Y/N");
            string userInput = Console.ReadLine();
            if(userInput == "y")
            {
                pet.needsClawTrim = true;
                Console.WriteLine("Claw trim added");
            }
            else
            {
                Console.WriteLine("No trim added");
            }
        }

        public void WashPet(Pet pet)
        {
            Console.WriteLine("Does your pet need a wash? Y/N");
            string userInput = Console.ReadLine();
            if (userInput == "y")
            {
                pet.needsWash = true;
                Console.WriteLine("Wash added");
            }
            else
            {
                Console.WriteLine("No wash added");
            }
        }
    }
}

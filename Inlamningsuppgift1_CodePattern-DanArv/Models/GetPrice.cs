using Inlamningsuppgift1_CodePattern_StevenErixon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_StevenErixon.Models
{
    public class GetPrice : IGetPrice
    {
        public void TotalPrice(Pet pet)
        {
            int totalPrice = CostOfServices.PriceForStay;
            if (pet.needsClawTrim)
            {
                totalPrice += CostOfServices.PriceForTrim;
                Console.WriteLine($"Clawtrim: {CostOfServices.PriceForTrim}kr");
            }
            if (pet.needsWash)
            {
                totalPrice += CostOfServices.PriceForWash;
                Console.WriteLine($"Wash: {CostOfServices.PriceForWash}kr");
            }
            Console.WriteLine($"Price for stay: {CostOfServices.PriceForStay}kr");
            Console.WriteLine($"Total price: {totalPrice}kr");
        }
    }
}

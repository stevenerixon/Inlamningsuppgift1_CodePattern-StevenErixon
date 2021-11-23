using Inlamningsuppgift1_CodePattern_StevenErixon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_StevenErixon.Interfaces
{
    public interface IKennelServices
    {
        void WashPet(Pet pet);
        void ClawTrimPet(Pet pet);
    }
}

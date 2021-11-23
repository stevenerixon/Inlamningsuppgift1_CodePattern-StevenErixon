using Inlamningsuppgift1_CodePattern_StevenErixon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_StevenErixon.Models
{
    public class Pet : IPet
    {
        public string Name { get; set; }
        public ICustomer Owner { get ; set; }
        public bool inKennel { get; set; } = false;

        public bool needsWash { get; set; } = false;
        public bool needsClawTrim { get; set; } = false;
    }
}

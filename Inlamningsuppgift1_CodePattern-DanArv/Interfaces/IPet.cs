using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_StevenErixon.Interfaces
{
    public interface IPet
    {
        string Name { get; set; }
        ICustomer Owner { get; set; }
        bool inKennel { get; set; }

    }
}

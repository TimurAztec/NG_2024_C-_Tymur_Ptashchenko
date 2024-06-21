using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Task.Interfaces
{
    public interface IPerson
    {
        int PersonId { get; }
        string Name { get; set; }
        string Address { get; set; }
    }
}

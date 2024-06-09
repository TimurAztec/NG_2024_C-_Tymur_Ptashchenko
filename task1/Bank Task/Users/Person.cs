using Bank_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Task.Users
{
    public class Person : Client, IPerson
    {
        public int PersonId { get; }
        public string Address { get; set; }
        public Person()
        {
            // Implementation to generate unique PersonId
        }
    }
}

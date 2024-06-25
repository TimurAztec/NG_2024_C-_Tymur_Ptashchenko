using Bank_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Task.Users
{
    public class Person : IPerson
    {
        public int PersonId { get; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Person()
        {
            // Implementation to generate unique PersonId
        }
    }
}

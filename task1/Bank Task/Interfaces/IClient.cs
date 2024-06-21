using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Task.Interfaces
{
    public interface IClient
    {
        int ClientId { get; }
        string AccountNumber { get; set; }
        string Name { get; set; }
        string Address { get; set; }

        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal GetBalance();
    }
}

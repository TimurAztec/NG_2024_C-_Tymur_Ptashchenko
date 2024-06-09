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
        string Name { get; set; }
        string AccountNumber { get; set; }

        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal GetBalance();
    }
}

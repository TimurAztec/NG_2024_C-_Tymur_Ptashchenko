using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Task.Users
{
    public class Client
    {
        public int ClientId { get; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }

        public Client() {
            // Implementation to generate unique ClientId
        }

        public void Deposit(decimal amount)
        {
            // Implementation to deposit amount into client's account
        }

        public void Withdraw(decimal amount)
        {
            // Implementation to withdraw amount from client's account
        }

        public decimal GetBalance()
        {
            // Implementation to retrieve current balance of the client
            return 0;
        }
    }
}

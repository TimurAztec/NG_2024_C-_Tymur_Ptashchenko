using Bank_Task.Financials;
using Bank_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Task.Users
{
    public class Client : Person, IClient
    {
        protected Balance Balance;
        public int ClientId { get; }
        public string AccountNumber { get; set; }

        public Client()
        {
            ClientId = new Random().Next(1, 100000);
            AccountNumber = Guid.NewGuid().ToString();
            Balance = new Balance(ClientId);
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return;
            }
            Balance.UpdateBalance(Balance.GetBalance() + amount);
            Console.WriteLine($"Deposited {amount}. New balance is {Balance.GetBalance()}.");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return;
            }
            if (amount > Balance.GetBalance())
            {
                return;
            }
            Balance.UpdateBalance(Balance.GetBalance() - amount);
            Console.WriteLine($"Withdrew {amount}. New balance is {Balance.GetBalance()}.");
        }

        public decimal GetBalance()
        {
            return Balance.GetBalance();
        }

        public void UpdateBalance(decimal amount)
        {
            Balance.UpdateBalance(amount);
            Console.WriteLine($"Balance updated. New balance is {Balance.GetBalance()}.");
        }
    }
}

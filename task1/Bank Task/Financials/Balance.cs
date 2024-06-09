using Bank_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Task.Financials
{
    public class Balance : IBalance
    {
        protected int BalanceId;
        protected int ClientId;
        protected decimal BalanceAmount;

        public Balance(int clientId)
        {
            // Implementation for unique BalanceIds
            ClientId = clientId;
        }

        public decimal GetBalance()
        {
            return BalanceAmount;
        }

        public void UpdateBalance(decimal amount)
        {
            this.BalanceAmount = amount;
        }
    }
}

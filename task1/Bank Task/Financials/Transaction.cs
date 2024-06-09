using Bank_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Task.Financials
{
    public class TransactionDetails
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }

        public TransactionDetails(int transactionId, decimal amount, DateTime timestamp)
        {
            TransactionId = transactionId;
            Amount = amount;
            Timestamp = timestamp;
        }
    }

    public class Transaction : ITransaction
    {
        protected int TransactionId;
        protected decimal Amount;
        protected DateTime Timestamp;

        public void RecordTransaction(TransactionDetails transactionData)
        {
            this.TransactionId = transactionData.TransactionId;
            this.Amount = transactionData.Amount;
            this.Timestamp = transactionData.Timestamp;
        }

        public TransactionDetails GetTransactionDetails(int transactionId)
        {            
            return new TransactionDetails(this.TransactionId, this.Amount, this.Timestamp);
        }
    }
}

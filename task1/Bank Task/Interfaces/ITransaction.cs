using Bank_Task.Financials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Task.Interfaces
{
    public interface ITransaction
    {
        void RecordTransaction(TransactionDetails transactionData);
        TransactionDetails GetTransactionDetails(int transactionId);
    }
}

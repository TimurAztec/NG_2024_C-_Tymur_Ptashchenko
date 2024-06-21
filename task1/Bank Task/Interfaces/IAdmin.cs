using Bank_Task.Financials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Task.Interfaces
{
    public interface IAdmin
    {
        int AdminId { get; }
        string Role { get; set; }
        string Name { get; set; }
        string Address { get; set; }

        void AddClient(IClient client);
        void RemoveClient(int clientId);
        List<Transaction> ViewTransactions();
        void GenerateReport();
    }
}

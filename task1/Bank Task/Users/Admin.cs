using Bank_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bank_Task.Users
{
    public class Admin : Person, IAdmin
    {
        public int AdminId { get; }
        public string Role { get; set; }
        public Admin()
        {
            // Implementation to generate unique AdminId
        }

        public void AddClient(IClient client)
        {
            // Implementation to add a new client to the system
        }

        public void RemoveClient()
        {
            // Implementation to remove an existing client from the system
        }

        public List<Transaction> ViewTransactions()
        {
            // Implementation to view transaction history
            return new List<Transaction>();
        }

        public void GenerateReport()
        {
            // Implementation to generate reports based on transactions
        }
    }
}

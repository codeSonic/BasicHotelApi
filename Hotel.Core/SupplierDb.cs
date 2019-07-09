using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core
{
    class SupplierDb
    {
        public Task<List<Supplier>> GetSuppliersAsync(string posId)
        {
            return Task.FromResult(new List<Supplier>
            {
                new Supplier{ Id = "S1", Name = "Supplier1", Family = "ean", Creds = "xyz", Connector = new EanConnector() },
                new Supplier{ Id = "S2", Name = "Supplier2", Family = "tourico", Creds = "abc", Connector = new TouricoConnector() }
            });
        }
    }
}

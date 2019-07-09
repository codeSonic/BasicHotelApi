using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core
{
    class ConfigProvider
    {
        public Task<string> GetPosIdAsync(string tenantId)
        {
            return Task.FromResult("pos101");
        }
    }
}

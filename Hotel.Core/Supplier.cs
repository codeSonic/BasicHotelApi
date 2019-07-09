using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Core
{
    class Supplier
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Creds { get; set; }
        public IConnector Connector { get; set; }
    }
}

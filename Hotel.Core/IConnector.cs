using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core
{
    interface IConnector
    {
        Task<List<Hotel>> SearchHotels(SearchRequest searchRequest);
    }
}
